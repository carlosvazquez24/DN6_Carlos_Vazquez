using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OPP.Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte cycle = 0;
            while(cycle < 10)
            {
                Vehicule vehicule = null;

                Console.WriteLine("Type a vehicule: Car, Truck or Train");
                string stringVehicule = Console.ReadLine();
                stringVehicule = stringVehicule.ToLower();


                switch(stringVehicule)
                {
                    case "car":
                        vehicule = new Car();
                        break;
                    case "train":
                        vehicule= new Train();
                        break;
                    case "truck":
                        vehicule = new Truck();
                        break;
                    default:
                        Console.WriteLine("Vehicule not found");
                        break;
                }

                if(vehicule != null)
                {
                    vehicule.VehiculeSound();
                }

                cycle++;
                Console.WriteLine("Remaining cycles:" + (10 - cycle));
                Console.WriteLine("");

            }
        }
    }
}
