using TestUWP.ViewModels;
using UWP_Toolkit.Math;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Microsoft.UI.Xaml.Controls;
using System;
using UWP.Markup;
using UWP.Toolkit.Controls;
using UWP.Toolkit.Controls.Enum;
using UWP.Toolkit.Controls.Struct;

namespace TestUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            IsEven.Text = 1.IsEven().ToString();
            IsOdd.Text = 1.IsOdd().ToString();
            IsDivisibleBy.Text = 14.IsDivisibleBy(6).ToString();
            IsMultipleOf.Text = 7.IsMultipleOf(3).ToString();
            IsPrime.Text = 7.IsPrime().ToString();
            InfoBarTest.IconSource = new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Accept };
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TextBlock titleContent = new TextBlock()
                .Text("Title Content")
                .Alignment(VerticalAlignment.Center, HorizontalAlignment.Left);

            var textSelect = new TextBlock()
                .Text("Select");
            textSelect.IsTextSelectionEnabled = true;

            StackPanel bodyContent = new StackPanel()
                .Alignment(VerticalAlignment.Center, HorizontalAlignment.Center)
                .Row(1)
                .AddChild(new TextBlock().Text("Popup Content"))
                .AddChild(new Button().Content("BUTTON 1"))
                .AddChild(new Button().Content("BUTTON 2"))
                .AddChild(textSelect)
                .AddChild(new Button().Content("BUTTON 3"));

            ContentOverlayPopup contentOverlayPopup = new ContentOverlayPopup()
                .TitleBarHeight(TitleBarSize.Tall)
                .TitleContent(titleContent)
                .CloseButtonToolTip("Close")
                .IsCloseButtonVisible(Visibility.Visible)
                .IsLightDismissEnabled(false)
                .BodyContent(bodyContent);
            contentOverlayPopup.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Toast toast = Toast.Instance;
            toast.SetTitleBarHeight(TitleBarSize.Tall);
            //toast.SetPadding(30);
            toast.SetAlignment(ToastAlignment.TopLeft);
            ToastItemParameters toastItemParameters1 = new ToastItemParameters
            {
                Title = "Title 1",
                Message = Guid.NewGuid().ToString(),
                CloseAfterSeconds = 10,
                IsIconVisible = true,
                IsClosable = true,
                Severity = InfoBarSeverity.Informational
            };
            toast.Show(toastItemParameters1);
            ToastItemParameters toastItemParameters2 = new ToastItemParameters
            {
                Title = "Title 2",
                Message = Guid.NewGuid().ToString(),
                CloseAfterSeconds = 10,
                IsIconVisible = false,
                IsClosable = false,
                Severity = InfoBarSeverity.Success
            };
            toast.Show(toastItemParameters2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Toast toast = Toast.Instance;
            stackpanelCount.Text = toast.Count().ToString();
        }
    }

    public class Avatar : Windows.UI.Xaml.Controls.PersonPicture
    {

    }
}
