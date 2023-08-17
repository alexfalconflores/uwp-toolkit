using System;
using System.Linq;
using Windows.Storage;

namespace UWP_Toolkit.Extensions;

public static class StorageFileExtensions
{
    public static string[] IMAGE_CONTENT_TYPES => new string[]
        {
            "image/jpeg",
            "image/pjpeg",
            "image/png",
            "image/x-png",
            "image/vnd.ms-photo",
            "image/bmp",
            "image/gif",
            "image/tiff",
            "image/x-emf",
            "image/x-icon",
            "image/svg+xml",
            "image/heic",
            "image/webp",
            "image/jxr",
            "image/x-wmf",
           };

    public static string[] IMAGE_FILE_TYPES => new string[]
    {
        ".jxr",
        ".heic",
        ".webp"
    };

    /// <summary>Check if the file is Image</summary>
    /// <param name="file"></param>
    /// <returns> Return <see langword="true"/> if the file is Image , Otherwise <see langword="false"/>.</returns>
    public static bool IsImage(this StorageFile file)
    {
        if (IMAGE_CONTENT_TYPES.Contains(file.ContentType.ToLower())) return true;
        else if (IMAGE_FILE_TYPES.Contains(file.FileType.ToLower())) return true;
        return false;
    }
}
