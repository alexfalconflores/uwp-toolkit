# Extensions
## StorageFileExtensions
### IsImage
Checks if the file is an image. 
- Returns `true` if the file is an image, `false` otherwise.
```csharp
var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/StoreLogo.png"));
var isImage = await file.IsImageAsync();
```
