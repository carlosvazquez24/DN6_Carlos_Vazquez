using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class Truck : Vehicule
    {
        public override void VehiculeSound()
        {
            AudioFileReader audio = new AudioFileReader("Resources/camion.wav");
            WaveOutEvent wave = new WaveOutEvent();

            wave.Init(audio);
            wave.Play();

            while (wave.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }

            audio.Dispose();
            wave.Dispose();
        }
    }
}
