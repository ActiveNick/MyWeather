using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MyWeather.Droid
{
    [Activity(Label = "MyWeather", MainLauncher = true)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            CrashManager.Register(this, Settings.HockeyAppId);

            MetricsManager.Register(Application, Settings.HockeyAppId);
            // If HockeyApp is not reporting metrics for Android, please uncomment the following line
            //MetricsManager.EnableUserMetrics();  // Need to see if Paul is right and this is required

            Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

