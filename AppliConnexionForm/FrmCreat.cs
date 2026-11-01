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
    public partial class FrmCreat : Form
    {
        public FrmCreat()
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
                cmd.CommandText = "Select * From Utilisateur where login = @login";
                //Obligatoire de passer par MySqlParameter sinon le texte saisi dans les TextBox n'est pas pris en compte
                MySqlParameter paramLogin = new MySqlParameter("@login", txtBxLog.Text);
                cmd.Parameters.Add(paramLogin);
                if (txtBxLog.Text == "" || txtBxPsw.Text == "" || txtBxConfPass.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Ce login est déjà utilisé, veuillez en choisir un autre !");
                        txtBxLog.Clear();
                        txtBxPsw.Clear();
                        txtBxConfPass.Clear();
                    }
                    else
                    {
                        if (txtBxLog.Text != "" && txtBxPsw.Text != "" && txtBxConfPass.Text != "")
                        {
                            if (txtBxPsw.Text != txtBxConfPass.Text)
                            {
                                MessageBox.Show("Les mots de passe ne correspondent pas !");
                                txtBxPsw.Clear();
                                txtBxConfPass.Clear();
                            }
                            else
                            {
                                MySqlCommand cmd2 = new MySqlCommand();
                                cmd2.Connection = cnx;
                                cmd2.CommandText = "Insert Into Utilisateur(login, psw) values (@login, @psw)";
                                //Ajout des paramètres pour la requête SQL
                                cmd2.Parameters.AddWithValue("@login", txtBxLog.Text);
                                cmd2.Parameters.AddWithValue("@psw", txtBxPsw.Text);
                                cmd2.ExecuteNonQuery();
                                //Message de confirmation
                                MessageBox.Show("Compte créé avec succès !", "", MessageBoxButtons.OK);
                                FrmCnx unObjCnx = new FrmCnx();
                                unObjCnx.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
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
            else { 
                
            }
            
        }
    }
}
