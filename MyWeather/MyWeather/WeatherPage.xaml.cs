using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWeather
{
	public partial class WeatherPage : ContentPage
    {
        // Weather Service Object to call the OpenWeatherMap API
        OpenWeatherMapService owms;

		public WeatherPage()
		{
			InitializeComponent();

            // Keep the service object alive for the duration of the app
            owms = new OpenWeatherMapService();
		}

        public async void OnGetWeatherClicked(object sender, EventArgs args)
        {
            // Get the location from the user (minus surrounding whitespace)
            string location = txtLocation.Text.Trim();

            // Make sure the location is not empty and display a message to the user
            if (location.Length == 0)
            {
                await DisplayAlert("Missing Location", "Please enter a valid location (e.g. city, state) and try again.", "Ok");
                return;
            }

            try
            {
                // Call the eather service and await the call
                var wr = await owms.GetWeather(location);
                if (wr != null)
                {
                    // Populate the labels in the form with the weather data
                    lblTemp.Text = String.Format("Temperature: {0}°F", (int)wr.main.temp);
                    lblTempBig.Text = String.Format("{0}°", (int)wr.main.temp);
                    lblHighTemp.Text = String.Format("High: {0}°F", (int)wr.main.temp_max);
                    lblLowTemp.Text = String.Format("Low: {0}°F", (int)wr.main.temp_min);

                    // TEXT-TO-SPEECH INTEGRATION
                    string greeter = "";
                    // Customize the speech intro depending on the platform
#if WINDOWS_PHONE || WINDOWS_UWP
                    greeter = "Hi, I'm Cortana";
#elif __IOS__
                    greeter = "My name is Siri";
#elif __ANDROID__
                    greeter = "This is the voice of Google";
#endif
                    // Build a message string to be spoken out loud
                    string weatherMessageTemplate = "{0}. The current temperature in {1} is {2}°F, with a high today of {3}° and a low of {4}°.";
                    string weatherMessage = string.Format(weatherMessageTemplate, greeter, wr.name, (int)wr.main.temp, (int)wr.main.temp_max, (int)wr.main.temp_min);
                    // Call the Text-to-Speech Dependency service on each platform to play the weather message with the platform's speech synthesizer
                    DependencyService.Get<ITextToSpeech>().Speak(weatherMessage);
                }

            }
            catch (Exception ex)
            {
                //TO DO: Log the exception somewhere
                await DisplayAlert("Error", "Unable to retrieve weather data. Please verify the city name and your Internet connection and try again.", "Ok");
            }
        }
	}
}
