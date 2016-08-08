using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWeather.UWP;
using Xamarin.Forms;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;

[assembly: Dependency(typeof(TextToSpeech_UWP))]
namespace MyWeather.UWP
{
    public class TextToSpeech_UWP : ITextToSpeech
    {
        public TextToSpeech_UWP() { }


        public async void Speak(string text)
        {
            // The object for controlling the speech synthesis engine (voice).
            SpeechSynthesizer speech = new SpeechSynthesizer();

            // The media object for controlling and playing audio.
            MediaElement mediaplayer = new MediaElement();

            //Retrieve the first female voice for the en-US culture (change this if you are not in the US!!!)
            speech.Voice = SpeechSynthesizer.AllVoices
                .First(i => (i.Gender == VoiceGender.Female && i.Description.Contains("United States")));

            // Generate the audio stream from plain text.
            SpeechSynthesisStream stream = await speech.SynthesizeTextToStreamAsync(text);

            // Send the stream to the media object.
            mediaplayer.SetSource(stream, stream.ContentType);
            mediaplayer.Play();
        }


    }
}
