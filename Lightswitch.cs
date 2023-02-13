using System;

namespace LampLightSwitch
{
    public class Lightswitch
    {
        private bool On;
        private int Height = 10;
        private int Width = 10;

        // Dit heet een constructor.
        public Lightswitch(bool isOn)   
        {
            On = isOn;
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
