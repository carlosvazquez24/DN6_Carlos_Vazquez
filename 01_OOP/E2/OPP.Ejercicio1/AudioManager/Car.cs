using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace AudioManager
{
    public class Car : Vehicule
    {
        public override void VehiculeSound()
        {
            AudioFileReader audio = new AudioFileReader("Resources/carro.wav");
            WaveOutEvent wave = new WaveOutEvent();

            wave.Init(audio);
            wave.Play();

            while(wave.PlaybackState== PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }

            audio.Dispose();
            wave.Dispose();


        }
    }
}
