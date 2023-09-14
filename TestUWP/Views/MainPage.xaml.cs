using TestUWP.ViewModels;
using UWP_Toolkit.Math;
using Windows.UI.Xaml.Controls;

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
        }
    }
}
