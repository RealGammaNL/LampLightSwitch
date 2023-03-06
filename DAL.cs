using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampLightSwitch
{
    public class DAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=Lightswitch;Integrated Security=True";
        public List<Lightswitch> lightswitches = new List<Lightswitch>();

        public DAL()
        {

        }

        public void FillListFromCode() 
        { 
        }


    }
}
