using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;

namespace ConnectContacts.Droid
{
    [Activity(Label = "ConnectContacts", Icon = "@drawable/icon", Theme = "@style/MainTheme",  ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            // No Splash Screen: Uncomment these lines if removing splash screen
            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();
            InitializeForms(bundle);
        }
    }
}

