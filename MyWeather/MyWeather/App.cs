using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyWeather
{
	public class App : Application
    {
		public App ()
		{
            MainPage = new WeatherPage();
		}

        protected override void OnStart()
        {
            // Handle when your app starts
            DependencyService.Get<IMetricsManagerService>().TrackEvent("AppStarted");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
