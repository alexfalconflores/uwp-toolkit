# Extensions
## SettingsStorageExtensions
### IsRoamingStorageAvailable
Check if the local storage in roaming is available

```csharp
ApplicationData appData = ApplicationData.Current;
bool isRoamingStorageAvailable = appData.IsRoamingStorageAvailable();
output: true or false
```

### SaveAsync
> (this StorageFolder folder, string name, T content)

Saves the serialized content in JSON format to a file int the specified folder.

```csharp
StorageFolder folder = ApplicationData.Current.LocalFolder;
await folder.SaveAsync("myFile", new { Name = "Alex Falcon", Age = 22 });
```

### SaveAsync
> (this ApplicationDataContainer settings, string key, T value)

Saves the serialized value in JSON format to the local settings.

```csharp
ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
await settings.SaveAsync("person", new { Name = "Alex Falcon", Age = 24 });
```

### ReadAsync
> (this StorageFolder folder, string name)

Reads and deserializes the content of a JSON file from the specified folder

```csharp
StorageFolder folder = ApplicationData.Current.LocalFolder;
var content = await folder.ReadAsync<Person>("person");
Output: { Name = "Alex Falcon", Age = 23 }
```

### ReadAsync
> (this ApplicationDataContainer settings, string key)

Reads and deserializes a value from the local settings.

```csharp
ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
var greeting = await settings.ReadAsync<string>("greeting");
Output: "Hello World!"
```

### SaveString
Saves a string value to the local settings.

```csharp
ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
settings.SaveString("person", "Alex Falcon");
```

### SaveFileAsync
Saves a byte array to a file in the specified folder.

```csharp
StorageFolder documents = KnownFolders.DocumentsLibrary;
StorageFile file = await documents.SaveFileAsync(new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }, "example.txt");
```

### ReadFileAsync
Reads the content of a file from the specified folder and returns it as a `byte array`.

```csharp
StorageFolder documents = KnownFolders.DocumentsLibrary;
byte[] content = await documents.ReadFileAsync("example.txt");
Output: { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }
```

### ReadBytesAsync
Reads the content of a file in the form of `byte array`.
- Returns a `byte array`

```csharp
StorageFolder documents = KnownFolders.DocumentsLibrary;
StorageFile file = await documents.GetFileAsync("example.txt");
byte[] content = await file.ReadBytesAsync();
output: { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }
```