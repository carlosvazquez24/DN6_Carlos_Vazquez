using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("I´m a dog");
            AudioFileReader audioFile = new AudioFileReader("Resources/POO_AnimalSounds_dog.wav");
            WaveOutEvent waveOutEvent= new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while(waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }

            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
