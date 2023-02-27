using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampLightSwitch
{
    internal class Strobe : Lamp
    {
        public int Frequency { get; set; }
        public Strobe(string color, int power, Lightswitch lightswitch, int frequency)
            : base(color, power, lightswitch)
        { 
            Frequency= frequency;
        }

        public override void Switch()
        {
            base.Switch();
            if (On)
            {
                // Frequency turn switch on or off.
            }
        }
    }
}
