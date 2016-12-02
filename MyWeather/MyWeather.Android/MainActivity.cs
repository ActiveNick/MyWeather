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

            // To learn more about HockeyApp integration on Xamarin.Android, read
            // https://support.hockeyapp.net/kb/client-integration-cross-platform/how-to-integrate-hockeyapp-with-xamarin
            CrashManager.Register(this, Settings.HockeyAppId);

            MetricsManager.Register(Application, Settings.HockeyAppId);
            MetricsManager.EnableUserMetrics();

            Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

