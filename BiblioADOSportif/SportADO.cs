using BiblioMetierSportif;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BiblioADOSportif
{
    public class SportADO
    {
        public static List<Sport> GetAllList()
        {
            List<Sport> lesSports = new List<Sport>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select id, lib from sport";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            string lib = rdr.GetString(1);
                            Sport unSport = new Sport(id, lib);
                            lesSports.Add(unSport);
                        }
                    }
                }
            }
            return lesSports;
        }
        public static void Insert(Sport unSport)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Insert into sport(lib) values(@lib)";
                cmd.Parameters.AddWithValue("@lib", unSport.Lib);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
