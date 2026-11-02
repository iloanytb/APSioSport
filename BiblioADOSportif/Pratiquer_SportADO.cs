using BiblioMetierSportif;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BiblioADOSportif
{
    public class Pratiquer_SportADO
    {
        public static List<Pratiquer_Sport> GetAll() 
        { 
            List<Pratiquer_Sport> lesPratiques = new List<Pratiquer_Sport>();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                string req = "Select idSport, idSportif, nivExp from pratiquer_sport";
                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int idSport = rdr.GetInt32(0);
                            int idSportif = rdr.GetInt32(1);
                            string nivExp = rdr.GetString(2);
                            Pratiquer_Sport unePratique = new Pratiquer_Sport(idSport, idSportif, nivExp);
                            lesPratiques.Add(unePratique);
                        }
                    }
                }
            }
            return lesPratiques;
        }
        public static DataTable GetSportNivById(int id)
        {
            DataTable data = new DataTable();
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;

                    cmd.CommandText = "Select PS.nivExp AS 'Niveau', S.lib AS 'Sport pratiqué' From Pratiquer_Sport PS Inner Join Sport S ON PS.idSport = S.id Where PS.idSportif = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(data);
            }


            return data;
        }
        //public static Pratiquer_Sport 
        public static void DelPratiqueSportifID(int id)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Delete from pratiquer_sport where idSportif=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Insert(Pratiquer_Sport unePratique)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Insert into pratiquer_sport(idSport, idSportif, nivExp) values(@idSport, @idSportif, @nivExp)";
                cmd.Parameters.AddWithValue("@idSport", unePratique.IdSport);
                cmd.Parameters.AddWithValue("@idSportif", unePratique.IdSportif);
                cmd.Parameters.AddWithValue("@nivExp", unePratique.NivExp);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Update(Pratiquer_Sport unePratique)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Update pratiquer_sport set nivExp=@nivExp where idSport=@idSport and idSportif=@idSportif";
                cmd.Parameters.AddWithValue("@idSport", unePratique.IdSport);
                cmd.Parameters.AddWithValue("@idSportif", unePratique.IdSportif);
                cmd.Parameters.AddWithValue("@nivExp", unePratique.NivExp);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Delete(Pratiquer_Sport unePratique)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Delete from pratiquer_sport where idSport=@idSport and idSportif=@idSportif and nivExp=@nivExp";
                cmd.Parameters.AddWithValue("@idSport", unePratique.IdSport);
                cmd.Parameters.AddWithValue("@idSportif", unePratique.IdSportif);
                cmd.Parameters.AddWithValue("@nivExp", unePratique.NivExp);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
