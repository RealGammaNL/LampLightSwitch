using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampLightSwitch
{
    public class DAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=Lightswitch;Integrated Security=True";
        public List<Lightswitch> lightswitches = new List<Lightswitch>();
        //public List<Lamp> lamps = new List<Lamp>();
        
     
        

        
        public DAL()
        {

        }

        public void FillListFromCode() 
        {
            lightswitches.Clear();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT id, brand, location FROM Lightswitch ORDER BY ID";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lightswitches.Add(new Lightswitch(Int32.Parse(reader[0].ToString())
                                                            , reader[1].ToString()
                                                            , reader[2].ToString()
                                                            ));
                        }
                    }
                }
            }
            

            //Lamp lamp1 = new Lamp("red", 25);
            //Lamp lamp2 = new Lamp("red", 25);
            //Lamp lamp3 = new Lamp("red", 25);
            //Lamp lamp4 = new Lamp("red", 25);

            //Lightswitch lightswitch1 = new Lightswitch(true);
            //Lightswitch lightswitch2 = new Lightswitch(true);

            //lightswitches.Add(lightswitch1);
            //lightswitches.Add(lightswitch2);

            //lamp1.Connect(lightswitch1);
            //lamp2.Connect(lightswitch1);
            //lamp3.Connect(lightswitch2);
            //lamp4.Connect(lightswitch2);

            //lightswitches.Add(lightswitch1);
            //lightswitches.Add(lightswitch2);
        }
    }
}
