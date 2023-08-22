# Services
## ThemeSelectorService

<details><summary>Notes</summary>

This `Class` is based on the `ThemeSelectorService` from the [**Windows Template Studio**](https://marketplace.visualstudio.com/items?itemName=TemplateStudio.TemplateStudioForUWP), but with some
changes to make it work with the `ThemeTitleBarService` from the **UWP Toolkit**. You can delete the `ThemeSelectorService` from the 
[**Windows Template Studio**](https://marketplace.visualstudio.com/items?itemName=TemplateStudio.TemplateStudioForUWP)
if you use the `ThemeTitleBarService` from the **UWP Toolkit** in your project.

Or you can also **use** `ThemeTitleBarService` inside your `ThemeSelectorService` from the **Windows Template Studio**.
Example:
- Put `private static ThemeTitleBarService themeTitleBar;` on top of the `SettingsKey const`.
- Add `themeTitleBar = new ThemeTitleBarService();` and `themeTitleBar.SetTheme();` in the `InitializeAsync` method.
```csharp
public static async Task InitializeAsync()
{
    Theme = await LoadThemeFromSettingsAsync();
    themeTitleBar = new ThemeTitleBarService();
    //Theme Default
    themeTitleBar.SetTheme();
}
```
- Add `themeTitleBar.SetTheme();` in the `SetRequestedThemeAsync` method.
```csharp
public static async Task SetRequestedThemeAsync()
{
	foreach (var view in CoreApplication.Views)
	{
		await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
		{
			if (Window.Current.Content is FrameworkElement frameworkElement)
			{
				frameworkElement.RequestedTheme = Theme;
				// Change Theme manually
				themeTitleBar.SetTheme();
			}
		});
	}
}
```
- Add `ThemeTitleBarService.CurrentWindow = Window.Current;` in the `App` Method.
```csharp
// App.xaml.cs
public App()
{
    InitializeComponent();
    // <...>
    // Deferred execution until used. Check https://docs.microsoft.com/dotnet/api/system.lazy-1 for further info on Lazy<T> class.
	_activationService = new Lazy<ActivationService>(CreateActivationService);

    ThemeTitleBarService.CurrentWindow = Window.Current;
}
```
</details>

### InitializeAsync
Initialize ThemeSelectorService, loading saved theme from settings and Initialize `ThemeTitleBarService`.

```csharp
```

### SetThemeAsync
Sets the application `theme`, updates the user interface and saves the theme in the application settings.

```csharp
```

### SetRequestedThemeAsync
Configures the requested `theme` in all application views, updating the user interface and the theme `title bar`.

```csharp
```
