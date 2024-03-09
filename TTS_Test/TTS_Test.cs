using System;
using System.Speech.Synthesis;

class TTS_Test
{
    static void Main(string[] args)
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Hello");
        }
        else
        {
            Console.WriteLine("Speech synthesis is only supported on Windows.");
        }
    }
}


/*
using System;
using System.Speech.Synthesis;

public class TTS_Test
{
    public void SpeakText(string text)
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);
        }
        else
        {
            Console.WriteLine("Speech synthesis is only supported on Windows.");
        }
    }
}
*/
