﻿using System;
using System.Threading.Tasks;
using UWP_Toolkit.Extensions;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace UWP_Toolkit.Services;

public static class ThemeSelectorService
{
    private static ThemeTitleBarService themeTitleBar;
    private const string SettingsKey = "AppBackgroundRequestedTheme";

    public static ElementTheme Theme { get; set; } = ElementTheme.Default;

    /// <summary>
    /// Initialize ThemeSelectorService, loading saved theme from settings and Initialize ThemeTitleBarService.
    /// </summary>
    /// <returns></returns>
    public static async Task InitializeAsync()
    {
        Theme = await LoadThemeFromSettingsAsync();
        themeTitleBar = new ThemeTitleBarService();
        // Theme Default
        themeTitleBar.SetTheme();
    }

    /// <summary>
    /// Sets the application theme, updates the user interface and saves the theme in the application settings.
    /// </summary>
    /// <param name="theme"></param>
    /// <returns></returns>
    public static async Task SetThemeAsync(ElementTheme theme)
    {
        Theme = theme;

        await SetRequestedThemeAsync();
        await SaveThemeInSettingsAsync(Theme);
    }

    /// <summary>
    /// Configures the requested theme in all application views, updating the user interface and the theme title bar.
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Loads the theme stored in the application settings and returns it as a theme value.
    /// </summary>
    /// <returns>
    /// Returns a <see cref="ElementTheme"/> value containing the requested theme.
    /// </returns>
    private static async Task<ElementTheme> LoadThemeFromSettingsAsync()
    {
        ElementTheme cacheTheme = ElementTheme.Default;
        string themeName = await ApplicationData.Current.LocalSettings.ReadAsync<string>(SettingsKey);

        if (!string.IsNullOrEmpty(themeName))
        {
            Enum.TryParse(themeName, out cacheTheme);
        }

        return cacheTheme;
    }

    /// <summary>
    /// Saves the specified theme in the application settings.
    /// </summary>
    /// <param name="theme"></param>
    /// <returns></returns>
    private static async Task SaveThemeInSettingsAsync(ElementTheme theme)
    {
        await ApplicationData.Current.LocalSettings.SaveAsync(SettingsKey, theme.ToString());
    }
}
