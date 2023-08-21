using System;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace UWP_Toolkit.Services;

public class ThemeTitleBarService
{
    readonly UISettings uISettings;
    private static Window currentWindow = null;
    public static Window CurrentWindow
    {
        get => currentWindow;
        // Check if the property is already set
        set => currentWindow = currentWindow is null ? value : throw new InvalidOperationException("The CurrentWindow property is already set");
    }

    // Colors
    static readonly Color lightForegroundColor = Color.FromArgb(255, 26, 26, 26); // #1a1a1a
    static readonly Color lightHoverForegroundColor = Color.FromArgb(255, 25, 25, 25); // #191919
    static readonly Color lightPressedForegroundColor = Color.FromArgb(255, 96, 96, 96); // #606060
    static readonly Color lightInactiveForegroundColor = Color.FromArgb(255, 160, 160, 160); // #606060
    static readonly Color lightHoverBackgroundColor = Color.FromArgb(255, 221, 221, 221);  // #dddddd
    static readonly Color lightPressedBackgroundColor = Color.FromArgb(255, 224, 224, 224);  // #f4f4f4

    static readonly Color darkForegroundColor = Color.FromArgb(255, 255, 255, 255); // #FFFFFF
    static readonly Color darkHoverForegroundColor = Color.FromArgb(255, 255, 255, 255); // #FFFFFF
    static readonly Color darkPressedForegroundColor = Color.FromArgb(255, 208, 208, 208); // #d0d0d0
    static readonly Color darkInactiveForegroundColor = Color.FromArgb(255, 111, 111, 111); // #6f6f6f
    static readonly Color darkHoverBackgroundColor = Color.FromArgb(255, 41, 41, 41); // #292929
    static readonly Color darkPressedBackgroundColor = Color.FromArgb(255, 56, 56, 56); // #383838

    public ThemeTitleBarService()
    {
        uISettings = new UISettings();
        uISettings.ColorValuesChanged += (_, __) => SetTheme();
    }

    /// <summary>
    /// Sets the theme of the user interface in the current window.
    /// </summary>
    public async void SetTheme()
    {
        if (currentWindow is not null)
            await currentWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => SetThemeForTitleBar(ThemeSelectorService.Theme));
        else
            CurrentWindow = Window.Current;
    }

    /// <summary>
    /// Sets the application bar title colors according to the theme provided.
    /// </summary>
    /// <param name="theme"></param>
    private void SetThemeForTitleBar(ElementTheme theme)
    {
        var isLightTheme = theme switch
        {
            ElementTheme.Default => Application.Current.RequestedTheme == ApplicationTheme.Light,
            ElementTheme.Light => true,
            ElementTheme.Dark => false,
            _ => (Window.Current.Content as FrameworkElement).RequestedTheme == ElementTheme.Light
        };
        ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;

        // Foreground
        titleBar.ForegroundColor = isLightTheme ? lightForegroundColor : darkForegroundColor;
        titleBar.ButtonForegroundColor = isLightTheme ? lightForegroundColor : darkForegroundColor;
        titleBar.ButtonHoverForegroundColor = isLightTheme ? lightHoverForegroundColor : darkHoverForegroundColor;
        titleBar.ButtonPressedForegroundColor = isLightTheme ? lightPressedForegroundColor : darkPressedForegroundColor;
        titleBar.ButtonInactiveForegroundColor = isLightTheme ? lightInactiveForegroundColor : darkInactiveForegroundColor;
        titleBar.InactiveForegroundColor = isLightTheme ? lightInactiveForegroundColor : darkInactiveForegroundColor;

        // Background
        titleBar.BackgroundColor = Colors.Transparent;
        titleBar.ButtonBackgroundColor = Colors.Transparent;
        titleBar.InactiveBackgroundColor = Colors.Transparent;
        titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        titleBar.ButtonHoverBackgroundColor = isLightTheme ? lightHoverBackgroundColor : darkHoverBackgroundColor;
        titleBar.ButtonPressedBackgroundColor = isLightTheme ? lightPressedBackgroundColor : darkPressedBackgroundColor;
    }
}
