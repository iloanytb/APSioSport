using AppliFormGestionSIOSport;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliConnexionForm
{
    public partial class FrmCnx : Form
    {
        public FrmCnx()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Select * From Utilisateur where login = @login AND psw = @psw";
                //Obligatoire de passr par MySqlParameter sinon le texte saisi dans les TextBox n'est pas pris en compte
                MySqlParameter paramLogin = new MySqlParameter("@login", txtBxLog.Text);
                MySqlParameter paramPsw = new MySqlParameter("@psw", txtBxMdp.Text);
                cmd.Parameters.Add(paramLogin);
                cmd.Parameters.Add(paramPsw);
                if(cmd.ExecuteScalar() != null)
                {
                    MessageBox.Show("Connexion réussie !");
                    FrmGest unObjGest = new FrmGest();
                    unObjGest.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mauvais login ou mot de passe. (Si vous n'avez pas de compte, appuyez sur le bouton 'Créer un compte')");
                    MessageBox.Show("Si vous voulez changer de mot de passe, appuyez sur le texte 'Mot de passe oublié ?'");
                    txtBxMdp.Clear();
                }
            }
         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreat unObjCreat = new FrmCreat();
            unObjCreat.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPswForg_Click(object sender, EventArgs e)
        {
            FrmPswForg unObjPswForg = new FrmPswForg();
            unObjPswForg.Show();
            this.Close();
        }
    }
}
