using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using HockeyApp;

[assembly: Xamarin.Forms.Dependency(typeof(MyWeather.iOS.MetricsManagerService))]
namespace MyWeather.iOS
{
    class MetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
            MetricsManager.TrackEvent(eventName);
        }
    }
}