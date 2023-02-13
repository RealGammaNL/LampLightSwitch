using System;


namespace LampLightSwitch
{
    public class Lamp
    {
        public string Color { get; set; }
        private Lightswitch Lightswitch;

         //This constructor forces you to add a colour when creating a new lamp.
        public Lamp(string color, Lightswitch lightswitch)
        {
            this.Color = color;
            this.Lightswitch = lightswitch;
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
