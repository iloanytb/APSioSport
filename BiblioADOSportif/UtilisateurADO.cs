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
    public class UtilisateurADO
    {
        public static List<Utilisateur> GetAllList()
        {
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select id, login, psw from utilisateur";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            string login = rdr.GetString(1);
                            string psw = rdr.GetString(2);
                            Utilisateur unUtilisateur = new Utilisateur(id, login, psw);
                            lesUtilisateurs.Add(unUtilisateur);
                        }
                    }
                }
            }
            return lesUtilisateurs;
        }
        public static void Insert(Utilisateur unUtilisateur)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Insert into utilisateur(login, psw) values(@login, @psw)";
                cmd.Parameters.AddWithValue("@login", unUtilisateur.Login);
                cmd.Parameters.AddWithValue("@psw", unUtilisateur.Psw);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Update(Utilisateur unUtilisateur)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Update utilisateur set psw = @psw where login = @login";
                cmd.Parameters.AddWithValue("@login", unUtilisateur.Login);
                cmd.Parameters.AddWithValue("@psw", unUtilisateur.Psw);
                cmd.ExecuteNonQuery();
            }
        }
        public static List<string> GetAllLogins()
        {
            List<string> logins = new List<string>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select login from utilisateur";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            logins.Add(rdr.GetString(0));
                        }
                    }
                }
            }
            return logins;
        }
    }
}
