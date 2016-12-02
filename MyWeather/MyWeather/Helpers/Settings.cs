using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeather
{
    public static class Settings
    {
        // HockeyApp App IDs, we have one for each supported platform
#if WINDOWS_UWP
        public static string HockeyAppId = "{INSERT YOUR UWP HOCKEYAPP ID HERE}";
#elif __ANDROID__
        public static string HockeyAppId = "{INSERT YOUR ANDROID HOCKEYAPP ID HERE}";
#elif __IOS__
        public static string HockeyAppId = "{INSERT YOUR iOS HOCKEYAPP ID HERE}";
#endif

    }
}
