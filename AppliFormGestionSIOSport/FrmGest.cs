using BiblioADOSportif;
using BiblioMetierSportif;
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
                //Preparation d'une boite de dialogue dont la réponse sera de type "DialogResult" (truc de base de Visual Studio)
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce sportif ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SportifADO.Delete(int.Parse(lstBxSport.SelectedItem.ToString().Split('\t')[0]));

                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //Vidage de la liste des sportifs
            lstBxSport.Items.Clear();
            //rechargement de la page
            FrmGest_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
                if (txtBxNom.Text == "" || txtBxPrenom.Text == "" || txtBxRue.Text == "" || txtBxCP.Text == "" || txtBxVille.Text == "" || dateTmNais.Value == date)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                    return;
                }
                else
                {

                    Sportif unSportif = new Sportif(txtBxNom.Text, txtBxPrenom.Text, dateTmNais.Value, txtBxRue.Text, txtBxCP.Text, txtBxVille.Text);
                    SportifADO.Insert(unSportif);
                }
            //Vidage de la liste des sportifs
            lstBxSport.Items.Clear();
            //Vidage des champs de saisie
            txtBxNom.Clear();
            txtBxPrenom.Clear();
            txtBxRue.Clear();
            txtBxCP.Clear();
            txtBxVille.Clear();

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
                //Désactivation de la sélection d'un sportif dans la liste
                lstBxSport.Enabled = false;
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
                Sportif unSportif = new Sportif(int.Parse(lstBxSport.SelectedItem.ToString().Split('\t')[0]), txtBxNom.Text, txtBxPrenom.Text, dateTmNais.Value, txtBxRue.Text, txtBxCP.Text, txtBxVille.Text);
                SportifADO.Update(unSportif);

                //Vidage de la liste des sportifs
                lstBxSport.Items.Clear();

                //Vidage des champs de saisie
                txtBxNom.Clear();
                txtBxPrenom.Clear();
                txtBxRue.Clear();
                txtBxCP.Clear();
                txtBxVille.Clear();

                

                //rechargement de la page
                FrmGest_Load(sender, e);
                //désactivation du bouton de validation de modification et activation du bouton d'ajout
                btnValMod.Visible = false;
                btnValMod.Enabled = false;
                btnAdd.Enabled = true;
                //Restauration de la couleur du bouton d'ajout
                btnAdd.BackColor = SystemColors.Control;
                //Activation de la sélection d'un sportif dans la liste
                lstBxSport.Enabled = true;
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
