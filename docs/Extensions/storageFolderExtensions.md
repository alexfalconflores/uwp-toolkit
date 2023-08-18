# Extensions
## StorageFolderExtensions
### GetFolderIfExistsAsync
Get the folder if exists, otherwise return `null`.
```csharp
var folder = await KnownFolders.PicturesLibrary.GetFolderIfExistsAsync("MyFolder");
```