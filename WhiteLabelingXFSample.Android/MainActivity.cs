using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace WhiteLabelingXFSample.Droid
{
#if APP1
    [Activity(Label = "App1", Icon = "@mipmap/iconApp1", Theme = "@style/splashscreenApp1", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
#elif APP2
   [Activity(Label = "App2", Icon = "@mipmap/iconApp2", Theme = "@style/splashscreenApp2", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
#else
   [Activity(Label = "App3", Icon = "@mipmap/iconApp3", Theme = "@style/splashscreenApp3", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
#endif
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}