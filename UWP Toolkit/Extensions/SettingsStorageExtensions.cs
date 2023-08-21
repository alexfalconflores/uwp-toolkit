using System;
using System.IO;
using System.Threading.Tasks;
using UWP_Toolkit.Helpers;
using Windows.Storage;
using Windows.Storage.Streams;

namespace UWP_Toolkit.Extensions;

// Use these extension methods to store and retrieve local and roaming app data
// More details regarding storing and retrieving app data at https://docs.microsoft.com/windows/uwp/app-settings/store-and-retrieve-app-data
public static class SettingsStorageExtensions
{
    private const string FileExtension = ".json";

    /// <summary>
    /// Check if the local storage in roaming is available
    /// </summary>
    /// <param name="appData"></param>
    /// <returns></returns>
    public static bool IsRoamingStorageAvailable(this ApplicationData appData) => appData.RoamingStorageQuota == 0;
    #region IsRoamingStorageAvailable example
    //ApplicationData appData = ApplicationData.Current;
    // bool isRoamingStorageAvailable = appData.IsRoamingStorageAvailable();
    // output: true or false
    #endregion IsRoamingStorageAvailable example

    /// <summary>
    /// Saves the serialized content in JSON format to a file int the specified folder.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="folder"></param>
    /// <param name="name"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    public static async Task SaveAsync<T>(this StorageFolder folder, string name, T content)
    {
        var file = await folder.CreateFileAsync(GetFileName(name), CreationCollisionOption.ReplaceExisting);
        var fileContent = await Json.StringifyAsync(content);

        await FileIO.WriteTextAsync(file, fileContent);
    }
    #region SaveAsync example
    //StorageFolder folder = ApplicationData.Current.LocalFolder;
    //await folder.SaveAsync("myFile", new { Name = "Alex Falcon", Age = 22 });
    #endregion SaveAsync example

    /// <summary>
    /// Reads and deserializes the content of a JSON file from the specified folder
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="folder"></param>
    /// <param name="name"></param>
    /// <returns>
    /// Return a <see cref="Task"/> that represents the asynchronous operation.
    /// </returns>
    public static async Task<T> ReadAsync<T>(this StorageFolder folder, string name)
    {
        if (!File.Exists(Path.Combine(folder.Path, GetFileName(name))))
            return default;
        var file = await folder.GetFileAsync($"{name}.json");
        var fileContent = await FileIO.ReadTextAsync(file);
        return await Json.ToObjectAsync<T>(fileContent);
    }
    #region ReadAsync example
    //StorageFolder folder = ApplicationData.Current.LocalFolder;
    //var content = await folder.ReadAsync<Person>("person");
    // output: { Name = "Alex Falcon", Age = 23 }
    #endregion ReadAsync example

    /// <summary>
    /// Saves the serialized value in JSON format to the local settings.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="settings"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static async Task SaveAsync<T>(this ApplicationDataContainer settings, string key, T value) => settings.SaveString(key, await Json.StringifyAsync(value));
    #region SaveAsync example
    //ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
    //await settings.SaveAsync("person", new { Name = "Alex Falcon", Age = 24 });
    #endregion SaveAsync example

    /// <summary>
    /// Saves a string value to the local settings.
    /// </summary>
    /// <param name="settings"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SaveString(this ApplicationDataContainer settings, string key, string value) => settings.Values[key] = value;
    #region SaveString example
    //ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
    //settings.SaveString("person", "Alex Falcon");
    #endregion SaveString example

    /// <summary>
    /// Reads and deserializes a value from the local settings.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="settings"></param>
    /// <param name="key"></param>
    /// <returns>
    /// Returns a <see cref="Task"/> that represents a deserialized value from the local settings.
    /// </returns>
    public static async Task<T> ReadAsync<T>(this ApplicationDataContainer settings, string key)
    {
        object obj = null;
        if (settings.Values.TryGetValue(key, out obj))
            return await Json.ToObjectAsync<T>((string)obj);
        return default;
    }
    #region ReadAsync example
    //ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
    //var greeting = await settings.ReadAsync<string>("greeting");
    // output: "Hello World!"
    #endregion ReadAsync example

    /// <summary>
    /// Saves a byte array to a file in the specified folder.
    /// </summary>
    /// <param name="folder"></param>
    /// <param name="content"></param>
    /// <param name="fileName"></param>
    /// <param name="options"></param>
    /// <returns>
    /// Return storage file.
    /// </returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static async Task<StorageFile> SaveFileAsync(this StorageFolder folder, byte[] content, string fileName, CreationCollisionOption options = CreationCollisionOption.ReplaceExisting)
    {
        if (content == null) throw new ArgumentNullException(nameof(content));
        if (string.IsNullOrEmpty(fileName)) throw new ArgumentException("File name is null or empty. Specify a valid file name", nameof(fileName));
        var storageFile = await folder.CreateFileAsync(fileName, options);
        await FileIO.WriteBytesAsync(storageFile, content);
        return storageFile;
    }
    #region SaveFileAsync example
    // StorageFolder documents = KnownFolders.DocumentsLibrary;
    // StorageFile file = await documents.SaveFileAsync(new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }, "example.txt");
    #endregion SaveFileAsync example

    /// <summary>
    /// Reads the content of a file from the specified folder and returns it as a byte array.
    /// </summary>
    /// <param name="folder"></param>
    /// <param name="fileName"></param>
    /// <returns>
    /// Returns a byte array.
    /// </returns>
    public static async Task<byte[]> ReadFileAsync(this StorageFolder folder, string fileName)
    {
        var item = await folder.TryGetItemAsync(fileName).AsTask().ConfigureAwait(false);

        if ((item != null) && item.IsOfType(StorageItemTypes.File))
        {
            var storageFile = await folder.GetFileAsync(fileName);
            byte[] content = await storageFile.ReadBytesAsync();
            return content;
        }
        return null;
    }
    #region ReadFileAsync example
    // StorageFolder documents = KnownFolders.DocumentsLibrary;
    // byte[] content = await documents.ReadFileAsync("example.txt");
    // output: { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }
    #endregion ReadFileAsync example

    /// <summary>
    /// Reads the content of a file in the form of byte array.
    /// </summary>
    /// <param name="file"></param>
    /// <returns>
    /// Return a byte array.
    /// </returns>
    public static async Task<byte[]> ReadBytesAsync(this StorageFile file)
    {
        if (file != null)
        {
            using IRandomAccessStream stream = await file.OpenReadAsync();
            using var reader = new DataReader(stream.GetInputStreamAt(0));
            await reader.LoadAsync((uint)stream.Size);
            var bytes = new byte[stream.Size];
            reader.ReadBytes(bytes);
            return bytes;
        }
        return null;
    }
    #region ReadBytesAsync example
    // StorageFolder documents = KnownFolders.DocumentsLibrary;
    // StorageFile file = await documents.GetFileAsync("example.txt");
    // byte[] content = await file.ReadBytesAsync();
    // output: { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }
    #endregion ReadBytesAsync example

    /// <summary>
    /// Gets the file name with the specified extension.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    private static string GetFileName(string name) => string.Concat(name, FileExtension);
}
