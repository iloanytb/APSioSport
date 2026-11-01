using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliConnexionForm
{
    public partial class FrmPswForg : Form
    {
        public FrmPswForg()
        {
            InitializeComponent();
        }

        private void FrmPswForg_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Attention, cela va fermer la fenêtre également !", "", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                FrmCnx unObjCnx = new FrmCnx();
                unObjCnx.Show();
                this.Close();
            }
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Select * From Utilisateur where login = @login";
                //Obligatoire de passer par MySqlParameter sinon le texte saisi dans les TextBox n'est pas pris en compte
                MySqlParameter paramLogin = new MySqlParameter("@login", txtBxLog.Text);
                cmd.Parameters.Add(paramLogin);
                if (string.IsNullOrEmpty(txtBxLog.Text) || string.IsNullOrEmpty(txtBxPsw.Text) || string.IsNullOrEmpty(txtBxConf.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = cnx;
                    cmd2.CommandText = "Select * From Utilisateur where psw = @psw AND login = @login";
                    //Obligatoire de passer par MySqlParameter sinon le texte saisi dans les TextBox n'est pas pris en compte
                    MySqlParameter paramPsw = new MySqlParameter("@psw", txtBxPsw.Text);
                    cmd2.Parameters.Add(paramPsw);
                    MySqlParameter paramLogin2 = new MySqlParameter("@login", txtBxLog.Text);
                    cmd2.Parameters.Add(paramLogin2);
                    if (cmd2.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Ceci est déjà votre mot de passe !");
                        txtBxPsw.Clear();
                        txtBxConf.Clear();
                    }
                    else
                    {

                        if (cmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("Ce login n'est pas le bon !");
                            txtBxLog.Clear();
                            txtBxPsw.Clear();
                            txtBxConf.Clear();
                        }
                        else
                        {
                            if (txtBxPsw.Text != txtBxConf.Text)
                            {
                                MessageBox.Show("Les mots de passe ne correspondent pas !");
                                txtBxPsw.Clear();
                                txtBxConf.Clear();
                            }
                            else
                            {
                                MySqlCommand cmd3 = new MySqlCommand();
                                cmd3.Connection = cnx;
                                cmd3.CommandText = "Update Utilisateur set psw = @psw where login = @login";
                                //Ajout des paramètres pour la requête SQL
                                cmd3.Parameters.AddWithValue("@login", txtBxLog.Text);
                                cmd3.Parameters.AddWithValue("@psw", txtBxPsw.Text);
                                cmd3.ExecuteNonQuery();
                                //message confirmation
                                MessageBox.Show("Mot de passe modifié !");
                                //Réouverture connexion
                                FrmCnx unObjCnx = new FrmCnx();
                                unObjCnx.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}