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

            while(true)
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

            }
        }
    }
}
