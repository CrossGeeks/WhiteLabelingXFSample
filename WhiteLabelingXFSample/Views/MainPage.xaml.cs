using System.ComponentModel;
using WhiteLabelingXFSample.ViewModels;
using Xamarin.Forms;

namespace WhiteLabelingXFSample
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
