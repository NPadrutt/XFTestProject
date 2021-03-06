﻿
using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace ConnectContacts.Droid
{
    [Activity(
        Label = "Playground.Forms"
        , MainLauncher = true
        , Icon = "@mipmap/icon"
        , Theme = "@style/MainTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainActivity));
            base.TriggerFirstNavigate();
        }
    }
}
