using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using HockeyApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace MyWeather.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Foundation.Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var manager = BITHockeyManager.SharedHockeyManager;
            manager.Configure(Settings.HockeyAppId);
            manager.StartManager();
            manager.Authenticator.AuthenticateInstallation(); // This line is obsolete in crash only builds (do we need it then?)

            Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
