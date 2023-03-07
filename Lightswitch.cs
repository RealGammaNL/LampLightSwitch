using System;
using System.Collections.Generic;

namespace LampLightSwitch
{
    public class Lightswitch
    {
        public int ID;
        public string Brand;
        public string Location;



        private bool On;
        private int Height = 10;
        private int Width = 10;
        public List<Lamp> lamps = new List<Lamp>();

        // Dit heet een constructor.
        public Lightswitch(int id, string brand, string location)   
        {
            ID = id;
            Brand = brand;
            Location = location;
            ID++;
        }
        public void AddLamp(Lamp lamp)
        {
           lamps.Add(lamp)
        }
        public void Toggle()
        {
            // On = !On
            if (On)
            { 
                On = false;
            }
            else
            { 
                On = true; 
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"De lichtknop staat aan: {On}");
        }
    }
}
