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
    public class SportifADO
    {
        public static DataTable GetAll()
        {
            DataTable data = new DataTable();
            List<Sportif> lesSportifs = new List<Sportif>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select id, nom, prenom, dateNais, rue, cp, ville from sportif";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(data);
                }
            }
            return data;
        }
        public static List<Sportif> GetAllList()
        {
            List<Sportif> lesSportifs = new List<Sportif>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select id, nom, prenom, dateNais, rue, cp, ville from sportif";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            string nom = rdr.GetString(1);
                            string prenom = rdr.GetString(2);
                            DateTime dateNais = rdr.GetDateTime(3);
                            string rue = rdr.GetString(4);
                            string cp = rdr.GetString(5);
                            string ville = rdr.GetString(6);
                            Sportif unSportif = new Sportif(id, nom, prenom, dateNais, rue, cp, ville);
                            lesSportifs.Add(unSportif);
                        }
                    }
                }
            }
            return lesSportifs;
        }
        public static DataTable GetByOther(string param, string recherche)
        {
            DataTable data = new DataTable();
            List<Sportif> lesSportifs = new List<Sportif>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select id, nom, prenom, dateNais, rue, cp, ville from sportif where " + param + " LIKE '%" + recherche + "%'";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            string nom = rdr.GetString(1);
                            string prenom = rdr.GetString(2);
                            DateTime dateNais = rdr.GetDateTime(3);
                            string rue = rdr.GetString(4);
                            string cp = rdr.GetString(5);
                            string ville = rdr.GetString(6);
                            Sportif unSportif = new Sportif(id, nom, prenom, dateNais, rue, cp, ville);
                            lesSportifs.Add(unSportif);
                        }
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(data);
                }
            }
            return data;
        }
        public static void Delete(int id)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                Pratiquer_SportADO.DelPratiqueSportifID(id);
                cnx.Open();
                string req = "Delete from sportif where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Update(Sportif unSportif)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Update sportif set nom=@nom, prenom=@prenom, dateNais=@dateNais, rue=@rue, cp=@cp, ville=@ville where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", unSportif.Id);
                    cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
                    cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
                    cmd.Parameters.AddWithValue("@dateNais", unSportif.DateNais);
                    cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
                    cmd.Parameters.AddWithValue("@cp", unSportif.Cp);
                    cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Insert(Sportif unSportif)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Insert into sportif(nom, prenom, dateNais, rue, cp, ville) values(@nom, @prenom, @dateNais, @rue, @cp, @ville)";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
                    cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
                    cmd.Parameters.AddWithValue("@dateNais", unSportif.DateNais);
                    cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
                    cmd.Parameters.AddWithValue("@cp", unSportif.Cp);
                    cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
