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
            DAL dal = new DAL();
            dal.FillListFromCode();

            //foreach(Lightswitch lightswitch in dal.lightswitches)
            //{
            //    foreach (Lamp lamp in lightswitch.lamps)
            //    {
            //        Console.WriteLine("Lightswitch "+ lightswitch.is    .
            //    }
            //}

            
            
            
            
            //Lightswitch lightswitch1 = new Lightswitch(true);
            //lightswitch1.Toggle();
            //lightswitch1.ShowStatus();

            //Lamp lamp1 = new Lamp("black", 100,lightswitch1);
            //lamp1.Color = "black";
            
            //Console.WriteLine(lamp1.Color);
            //Console.ReadLine();

            //Strobe strobe1 = new Strobe("blue", 20, lightswitch1, 200);
        }
    }
}
