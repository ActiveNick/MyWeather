using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.HockeyApp;

[assembly: Xamarin.Forms.Dependency(typeof(MyWeather.WinPhone.MetricsManagerService))]
namespace MyWeather.WinPhone
{
    class MetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
            HockeyClient.Current.TrackEvent(eventName);
        }
    }
}
