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
NuGet\Install-Package AlexFalconFlores.UWP.Toolkit -Version 0.0.4
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
    - [ObservableCollectionExtensions](docs/extensions/observableCollectionExtensions.md)
        - [RemoveAll(match)](docs/extensions/observableCollectionExtensions.md#RemoveAll(match))
        - [RemoveAll(match,action)](docs/extensions/observableCollectionExtensions.md#RemoveAll(match,action))
    - [StorageFolderExtensions](docs/extensions/storageFolderExtensions.md)
        - [GetFolderIfExistsAsync](docs/extensions/storageFolderExtensions.md#GetFolderIfExistsAsync)
    - [StorageFileExtensions](docs/extensions/storageFolderExtensions.md)
        - [IsImage](docs/extensions/storageFolderExtensions.md#IsImage)
    - [ScrollViewerExtension](docs/extensions/scrollViewerExtension.md)
        - [GetScrollViewer](docs/extensions/scrollViewerExtension.md#GetScrollViewer)



## Library Dependencies 📚
- PolySharp
- SQLitePCLRaw.bundle_e_sqlite3
- Microsoft.Data.Sqlite.Core