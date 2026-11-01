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

namespace AppliFormGestionSIOSport
{
    public partial class FrmGest : Form
    {
        public FrmGest()
        {
            InitializeComponent();
        }

        private void FrmGest_Load(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Select * From Sportif";
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string ligne = "";
                        for (int i = 0; i < rdr.FieldCount; i++)
                            ligne += rdr.GetValue(i).ToString() + "\t";
                        lstBxSport.Items.Add(ligne);
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Delete From Sportif where id = @id";
                cmd.Parameters.AddWithValue("@id", lstBxSport.SelectedItem.ToString().Split('\t')[0]);
                //Preparation d'une boite de dialogue dont la réponse sera de type "DialogResult" (truc de base de Visual Studio)
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce sportif ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Vidage de la liste des sportifs
            lstBxSport.Items.Clear();
            //rechargement de la page
            FrmGest_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                if (txtBxNom.Text == "" || txtBxPrenom.Text == "" || txtBxRue.Text == "" || txtBxCP.Text == "" || txtBxVille.Text == "" || dateTmNais.Value == DateTime.MinValue || dateTmNais.Value == DateTime.UtcNow)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                    return;
                }
                else
                {


                    cnx.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "Insert Into Sportif(nom, prenom,dateNais, rue, cp, ville) values (@nom, @prenom, @dateNais, @rue, @cp, @ville)";
                    //Ajout des paramètres pour la requête SQL
                    cmd.Parameters.AddWithValue("@nom", txtBxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtBxPrenom.Text);
                    cmd.Parameters.AddWithValue("@dateNais", dateTmNais.Value);
                    cmd.Parameters.AddWithValue("@rue", txtBxRue.Text);
                    cmd.Parameters.AddWithValue("@cp", txtBxCP.Text);
                    cmd.Parameters.AddWithValue("@ville", txtBxVille.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            //Vidage de la liste des sportifs
            lstBxSport.Items.Clear();
            //Vidage des champs de saisie
            txtBxNom.Clear();
            txtBxPrenom.Clear();
            txtBxRue.Clear();
            txtBxCP.Clear();
            txtBxVille.Clear();

            dateTmNais.Value = DateTime.Now;

            //rechargement de la page
            FrmGest_Load(sender, e);
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            if (lstBxSport.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un sportif à modifier !");
            }
            else
            {
                //Récup des items de lstBoxSport
                txtBxNom.Text = lstBxSport.SelectedItem.ToString().Split('\t')[1];
                txtBxPrenom.Text = lstBxSport.SelectedItem.ToString().Split('\t')[2];
                dateTmNais.Value = DateTime.Parse(lstBxSport.SelectedItem.ToString().Split('\t')[3]);
                txtBxRue.Text = lstBxSport.SelectedItem.ToString().Split('\t')[4];
                txtBxCP.Text = lstBxSport.SelectedItem.ToString().Split('\t')[5];
                txtBxVille.Text = lstBxSport.SelectedItem.ToString().Split('\t')[6];
                //activation du bouton de validation de modification et désactivation du bouton d'ajout
                btnValMod.Visible = true;
                btnValMod.Enabled = true;
                btnAdd.Enabled = false;
                //Grisage du bouton pour signifier qu'il est désactivé
                btnAdd.BackColor = Color.Gray;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValMod_Click(object sender, EventArgs e)
        {
            if (txtBxNom.Text == "" || txtBxPrenom.Text == "" || txtBxRue.Text == "" || txtBxCP.Text == "" || txtBxVille.Text == "" || dateTmNais.Value == DateTime.MinValue || dateTmNais.Value == DateTime.UtcNow)
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
                using (MySqlConnection cnx = new MySqlConnection(chaine))
                {
                    cnx.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "Update Sportif Set nom = @nom, prenom = @prenom, dateNais = @dateNais, rue = @rue, cp = @cp, ville = @ville WHERE id = @id";//, nivExp = @nivExp, sport = @sport
                                                                                                                                                                   //Ajout des paramètres pour la requête SQL
                    cmd.Parameters.AddWithValue("@nom", txtBxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtBxPrenom.Text);
                    cmd.Parameters.AddWithValue("@dateNais", dateTmNais.Value);
                    cmd.Parameters.AddWithValue("@rue", txtBxRue.Text);
                    cmd.Parameters.AddWithValue("@cp", txtBxCP.Text);
                    cmd.Parameters.AddWithValue("@ville", txtBxVille.Text);
                    //cmd.Parameters.AddWithValue("@nivExp", listeBxExp.SelectedItem);
                    //cmd.Parameters.AddWithValue("@sport", txtBxSport.Text);
                    cmd.Parameters.AddWithValue("@id", lstBxSport.SelectedItem.ToString().Split('\t')[0]);
                    cmd.ExecuteNonQuery();
                }
                //Vidage de la liste des sportifs
                lstBxSport.Items.Clear();

                //Vidage des champs de saisie
                txtBxNom.Clear();
                txtBxPrenom.Clear();
                txtBxRue.Clear();
                txtBxCP.Clear();
                txtBxVille.Clear();

                dateTmNais.Value = DateTime.Now;

                //rechargement de la page
                FrmGest_Load(sender, e);
                //désactivation du bouton de validation de modification et activation du bouton d'ajout
                btnValMod.Visible = false;
                btnValMod.Enabled = false;
                btnAdd.Enabled = true;
                //Restauration de la couleur du bouton d'ajout
                btnAdd.BackColor = SystemColors.Control;
            }
        }

        private void btnModifSprtNv_Click(object sender, EventArgs e)
        {
            if (lstBxSport.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un sportif à modifier !");
            }
            else
            {
                //Récup des items de lstBoxSport
                string nom = lstBxSport.SelectedItem.ToString().Split('\t')[1];
                string prenom = lstBxSport.SelectedItem.ToString().Split('\t')[2];
                DateTime dateNais = DateTime.Parse(lstBxSport.SelectedItem.ToString().Split('\t')[3]);
                string rue = lstBxSport.SelectedItem.ToString().Split('\t')[4];
                string cp = lstBxSport.SelectedItem.ToString().Split('\t')[5];
                string ville = lstBxSport.SelectedItem.ToString().Split('\t')[6];
                FrmModifNivSport unObjModNiv = new FrmModifNivSport(nom, prenom, dateNais, rue, cp, ville);
                unObjModNiv.Show();
            }
        }
    }
}
