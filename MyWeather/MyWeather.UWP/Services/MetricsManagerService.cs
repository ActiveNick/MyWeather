using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.HockeyApp;

[assembly: Xamarin.Forms.Dependency(typeof(MyWeather.UWP.MetricsManagerService))]
namespace MyWeather.UWP
{
    class MetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
            HockeyClient.Current.TrackEvent(eventName);
        }
    }
}
