﻿using AVFoundation;
using Xamarin.Forms;
using TicTacToe.iOS;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TicTacToe.iOS
{
    public class TextToSpeechService : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            speechSynthesizer.SpeakUtterance(new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.DefaultSpeechRate,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = .5f,
                PitchMultiplier = 1.0f
            });
        }
    }
}
