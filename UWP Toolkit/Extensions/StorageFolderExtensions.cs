using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace UWP_Toolkit.Extensions;

public static class StorageFolderExtensions
{
    /// <summary>
    /// Get the folder if exist.
    /// </summary>
    /// <param name="folder"><see cref="StorageFolder"/></param>
    /// <param name="name">name's folder</param>
    /// <returns>
    /// Returns <see cref="StorageFolder"/> if exists , otherwise <see langword="null"/>
    /// </returns>
    public static async Task<StorageFolder> GetFolderIfExistsAsync(this StorageFolder folder, string name)
    {
        try
        {
            if (folder is null) throw new ArgumentNullException(nameof(folder));
            return await folder.GetFolderAsync(name);
        }
        catch (Exception)
        {
            // Exception thrown: 'System.IO.FileNotFoundException'
            // The system cannot find the file specified. (Exception from HRESULT: 0x80070002)
            return null;
        }
    }
}
