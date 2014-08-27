﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWeather.WinPhone;
using Windows.Phone.Speech.Synthesis;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech_WinPhone))]
namespace MyWeather.WinPhone
{
    public class TextToSpeech_WinPhone : ITextToSpeech
    {
        public TextToSpeech_WinPhone() { }


        public async void Speak(string text)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync(text);
        }
    }
}
