using System;
using System.Data.SqlClient;

namespace LampLightSwitch
{
    public class Lamp
    {
        public string Color { get; set; }
        private Lightswitch Lightswitch;
        private int Power { get; set; }
        public bool On { get; set; }

         //This constructor forces you to add a colour when creating a new lamp.
        public Lamp(string color, int power, Lightswitch lightswitch)
        {
            Color = color;
            Lightswitch = lightswitch;
            Power = power;
        }

        public virtual void Switch()
        {
            On = !On;
        }
        //public void SetColor(string color) 
        //{ 
        //    Color = color; 
        //}

        //public string GetColor()
        //{
        //    return Color;
        //}
    }
}
