using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Hackathon
{
    public class Database
    {
        private string dbpass = "Testing123";

        public MySqlConnection Connect()
        {
            string con = "server=127.0.0.1;uid=root;pwd=" + dbpass + ";database=hackathon";
            MySqlConnection conConn = new MySqlConnection(con);


            try
            {
                conConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Established" + ex);
            }

            return conConn;
        }

        public List<Info> fetchData()
        {
            List<Info> info = new List<Info>();
            using (MySqlConnection connection = Connect())
            {
                try
                {
                    
                    string query = "SELECT moneyRaised, mealsProvided, familiesHelped FROM infographics";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Info user = new Info
                            {
                                moneyRaised = reader.GetDouble("moneyRaised"),
                                mealsProvided = reader.GetInt32("mealsProvided"),
                                familiesHelped = reader.GetInt32("familiesHelped")
                            };
                            info.Add(user);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return info;
        }
    }
}
