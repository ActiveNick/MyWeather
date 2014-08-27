using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWeather
{
	public partial class WeatherXaml
	{
        OpenWeatherMapService owms;

		public WeatherXaml ()
		{
			InitializeComponent ();

            owms = new OpenWeatherMapService();
		}

        public async void OnGetWeatherClicked(object sender, EventArgs args)
        {
            string location = txtLocation.Text.Trim();

            try
            {
                var wr = await owms.GetWeather(location);
                if (wr != null)
                {
                    lblTemp.Text = String.Format("Temperature: {0}°F", (int)wr.MainWeather.Temp);
                    lblTempBig.Text = String.Format("{0}°", (int)wr.MainWeather.Temp);
                    lblHighTemp.Text = String.Format("High: {0}°F", (int)wr.MainWeather.MaximumTemp);
                    lblLowTemp.Text = String.Format("Low: {0}°F", (int)wr.MainWeather.MinimumTemp);

                    // TEXT-TO-SPEECH INTEGRATION
                    string greeter = "";
#if WINDOWS_PHONE
                    greeter = "Hi, I'm Cortana";
#elif __IOS__
                    greeter = "My name is Siri";
#elif __ANDROID__
                    greeter = "This is the voice of Google";
#endif
                    string weatherMessageTemplate = "{0}. The current temperature in {1} is {2}°F, with a high today of {3}° and a low of {4}°.";
                    string weatherMessage = string.Format(weatherMessageTemplate, greeter, wr.Name, (int)wr.MainWeather.Temp, (int)wr.MainWeather.MaximumTemp, (int)wr.MainWeather.MinimumTemp);
                    DependencyService.Get<ITextToSpeech>().Speak(weatherMessage);
                }

            }
            catch (Exception ex)
            {
                //TO DO: Log the exception somewhere
                DisplayAlert("Error", "Unable to retrieve weather data. Please verify the city name and your Internet connection and try again.", "Ok", "");
            }
        }
	}
}
