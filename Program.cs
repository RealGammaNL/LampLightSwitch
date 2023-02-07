using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampLightSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Lightswitch lightswitch1 = new Lightswitch();
            //lightswitch1.Toggle();
            //lightswitch1.ShowStatus();

            //Lightswitch lightswitch2 = new Lightswitch();
            //lightswitch2.Toggle();
            //lightswitch2.ShowStatus();
            //Console.ReadKey();

            Lightswitch lightswitch3 = new Lightswitch(false);
            Console.WriteLine("Do you want to turn the lightswitch on or off? on/off?");
            string status = Console.ReadLine();

            if (status == "on")
            {
                lightswitch3.Toggle();
                lightswitch3.ShowStatus();
            }
            else
            {
                Console.WriteLine($"De lichtknop staat al uit!");
            }
            Console.ReadKey();


        }
    }
}
