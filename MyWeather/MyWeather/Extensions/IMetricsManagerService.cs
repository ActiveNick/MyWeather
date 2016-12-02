using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeather
{
    public interface IMetricsManagerService
    {
        void TrackEvent(string eventName);
    }
}
