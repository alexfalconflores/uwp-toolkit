# UWP Toolkit ⚒️
> This project uses `C# 11` with the [`PolySharp`](https://github.com/Sergio0694/PolySharp/tree/main) library. The minimum version is Windows 10, `1903` (Build,18362).
<br/>

[![NuGet](https://img.shields.io/nuget/dt/AlexFalconFlores.UWP.Toolkit.svg)](https://www.nuget.org/stats/packages/AlexFalconFlores.UWP.Toolkit?groupby=Version) 
[![NuGet](https://img.shields.io/nuget/vpre/AlexFalconFlores.UWP.Toolkit.svg)](https://www.nuget.org/packages/AlexFalconFlores.UWP.Toolkit/)
<a href="https://www.nuget.org/packages/AlexFalconFlores.UWP.Toolkit">
    <img src="https://raw.githubusercontent.com/alexfalconflores/alexfalconflores/main/img/nuget-banner.svg" height=20 alt="Go to Nuget"/>
</a>

## Installation 📦
This project is available as a [NuGet package](https://www.nuget.org/packages/AlexFalconFlores.UWP.Toolkit). You can install it using the NuGet Package Console window:
```
NuGet\Install-Package AlexFalconFlores.UWP.Toolkit -Version 0.0.5
```

## Documentation 📖
- **Extensions**
    - [ResourceExtensions](docs/extensions/resourceExtensions.md)
        - [GetLocalized](docs/extensions/resourceExtensions.md#GetLocalized)
        - [Format](docs/extensions/resourceExtensions.md#Format)
        - [GetStyle](docs/extensions/resourceExtensions.md#GetStyle)
        - [GetDouble](docs/extensions/resourceExtensions.md#GetDouble)
    - [StringExtensions](docs/extensions/stringExtensions)
        - [TrimAround](docs/extensions/stringExtensions#TrimAround)
        - [IsNullOrEmpty](docs/extensions/stringExtensions#IsNullOrEmpty)
        - [IsNullOrWhiteSpace](docs/extensions/stringExtensions#IsNullOrWhiteSpace)
        - [Join](docs/extensions/stringExtensions#Join)
        - [Repeat](docs/extensions/stringExtensions#Repeat)
        - [ToCamelCase](docs/extensions/stringExtensions#ToCamelCase)
        - [ToPascalCase](docs/extensions/stringExtensions#ToPascalCase)
        - [ToKebabCase](docs/extensions/stringExtensions#ToKebabCase)
        - [ToSnakeCase](docs/extensions/stringExtensions#ToSnakeCase)
        - [HtmlEscape](docs/extensions/stringExtensions#HtmlEscape)
        - [HtmlUnEscape](docs/extensions/stringExtensions#HtmlUnEscape)
    - [ObservableCollectionExtensions](docs/extensions/observableCollectionExtensions.md)
        - [RemoveAll(match)](docs/extensions/observableCollectionExtensions.md#RemoveAll(match))
        - [RemoveAll(match,action)](docs/extensions/observableCollectionExtensions.md#RemoveAll(match,action))
    - [StorageFolderExtensions](docs/extensions/storageFolderExtensions.md)
        - [GetFolderIfExistsAsync](docs/extensions/storageFolderExtensions.md#GetFolderIfExistsAsync)
    - [StorageFileExtensions](docs/extensions/storageFolderExtensions.md)
        - [IsImage](docs/extensions/storageFolderExtensions.md#IsImage)
    - [ScrollViewerExtension](docs/extensions/scrollViewerExtension.md)
        - [GetScrollViewer](docs/extensions/scrollViewerExtension.md#GetScrollViewer)
    - [EnumerableExtensions](docs/extensions/enumerableExtensions.md)
        - [Flatten](docs/extensions/EnumerableExtensions.md#Flatten)
        - [ToObservableCollection](docs/extensions/EnumerableExtensions.md#ToObservableCollection)
    - [CollectionExtensions](docs/extensions/collectionExtensions.md)
        - [Fill](docs/extensions/collectionExtensions.md#Fill)
    - [SettingsStorageExtensions](docs/extensions/settingsStorageExtensions.md)
        - [IsRoamingStorageAvailable](docs/extensions/settingsStorageExtensions.md#IsRoamingStorageAvailable)
        - [SaveAsync(this StorageFolder folder, string name, T content)](docs/extensions/settingsStorageExtensions.md#SaveAsync)
        - [SaveAsync(this ApplicationDataContainer settings, string key, T value)](docs/extensions/settingsStorageExtensions.md#SaveAsync)
        - [ReadAsync(this StorageFolder folder, string name)](docs/extensions/settingsStorageExtensions.md#ReadAsync)
        - [ReadAsync(this ApplicationDataContainer settings, string key)](docs/extensions/settingsStorageExtensions.md#ReadAsync)
        - [SaveString](docs/extensions/settingsStorageExtensions.md#SaveString)
        - [SaveFileAsync](docs/extensions/settingsStorageExtensions.md#SaveFileAsync)
        - [ReadFileAsync](docs/extensions/settingsStorageExtensions.md#ReadFileAsync)
        - [ReadBytesAsync](docs/extensions/settingsStorageExtensions.md#ReadBytesAsync)
- **Helpers**
    - [Json](docs/helpers/json.md)
        - [ToObjectAsync](docs/helpers/json.md#ToObjectAsync)
        - [StringifyAsync](docs/helpers/json.md#StringifyAsync)
- **Math**
    - [IntegerExtensions](docs/math/integer.md)
        - [Fibonacci](docs/math/integer.md#Fibonacci)
- **Services**
	- [ThemeTitleBarService](docs/services/themeTitleBarService.md)
	- [ThemeSelectorService](docs/services/themeSelectorService.md)




## Library Dependencies 📚
- PolySharp
- SQLitePCLRaw.bundle_e_sqlite3
- Microsoft.Data.Sqlite.Core
- Newtonsoft.Json