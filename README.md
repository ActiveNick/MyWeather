MyWeather
=========
Author: Nick Landry, Senior Technical Evangelist, Microsoft
Blog: www.AgeofMobility.com
Twitter: @ActiveNick

PROJECT DESCRIPTION
-------------------
MyWeather is Cross-Platform Mobile Weather App for iOS, Android and WP8 built in C# with Xamarin 3. This app is a demo designed to illustrate how to use Xamarin.Forms to share 100% of the UI code. The demo app lets the user specify a location (city, state) to pull weather info at that location using OpenWeatherMap.

APP FEATURES & IMPLEMENTATION
-----------------------------
- The UI was designed using Xamarin's implementation of XAML.
- Uses HttpClient to call OpenWeatherMap REST service.
- JSON data deserialization with Newtonsoft JSON.NET.
- Text-to-Speech integration on all 3 platforms using the Xamarin.Forms DependecyService.
- Platform differentiation in code via #if conditional compilation directives.
- Platform differentiation in UI via <OnPlatform> XAML elements in Xamarin.Forms.

More features will be added over time to flesh out this demo app. Feel free to post your feedback if you have questions or suggestions.

Thanks,
Nick

REQUIREMENTS
------------
This demo project requires at least the Xamarin.iOS and Xamarin.Android Indie Editions due to the use of Xamarin.Forms. To open the project in Visual Studio instead of Xamarin Studio, you will need Xamarin.iOS and Xamarin.Android Business Editions.
For more info on Xamarin, visit www.Xamarin.com.

ACKNOWLEDGEMENTS
----------------
- Special thanks to James Montemagno for his initial OpenWeatherMap code snippet and service recommendation.
- Thanks to Joseph Hill and the Xamarin team for providing me with their software and support.
