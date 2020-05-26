using System;
using Xamarin.Forms;

namespace WhiteLabelingXFSample
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
            WhiteLabelingConfig.Instance.Init();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
