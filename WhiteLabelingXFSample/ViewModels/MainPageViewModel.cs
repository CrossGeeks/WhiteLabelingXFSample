using System;
using System.Windows.Input;
using WhiteLabelingXFSample.Resources;
using Xamarin.Forms;

namespace WhiteLabelingXFSample.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand LoginCommand => new Command(async () =>
        {
            await App.Current.MainPage.DisplayAlert("Error", TranslateExtension.GetValue("LoginError"), "Ok");
          });

        public MainPageViewModel()
        {

        }
    }
}
