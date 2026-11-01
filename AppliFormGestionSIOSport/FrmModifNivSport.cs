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

namespace AppliFormGestionSIOSport
{
    public partial class FrmModifNivSport : Form
    {
        private string nom;
        private string prenom;
        private DateTime dateNais;
        private string rue;
        private string cp;
        private string ville;
        //il faut passer par un contructeur pour récupérer les informations du sportif sélectionné dans la liste de FrmGest
        public FrmModifNivSport(string nom, string prenom, DateTime dateNais, string rue, string cp, string ville)
        {
            InitializeComponent();
            this.nom = nom;
            this.prenom = prenom;
            this.dateNais = dateNais;
            this.rue = rue;
            this.cp = cp;
            this.ville = ville;

        }

        private void FrmModifNivSport_Load(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                MySqlCommand cmd2 = new MySqlCommand("Select id from Sportif where nom = @nom AND prenom = @prenom AND dateNais = @dateNais AND rue = @rue AND cp = @cp AND ville = @ville");
                cmd2.Parameters.AddWithValue("@nom", nom);
                cmd2.Parameters.AddWithValue("@prenom", prenom);
                cmd2.Parameters.AddWithValue("@dateNais", dateNais);
                cmd2.Parameters.AddWithValue("@rue", rue);
                cmd2.Parameters.AddWithValue("@cp", cp);
                cmd2.Parameters.AddWithValue("@ville", ville);
                cmd2.Connection = cnx;
                //exécution de la requête et récupération du résultat
                string id = cmd2.ExecuteScalar().ToString();


                cmd.CommandText = "Select PS.nivExp AS 'Niveau', S.lib AS 'Sport pratiqué' From Pratiquer_Sport PS Inner Join Sport S ON PS.idSport = S.id Where PS.idSportif = @id";
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Configuration du ListView
                listeSportNivView.View = View.Details;
                listeSportNivView.GridLines = true;
                listeSportNivView.FullRowSelect = true;
                listeSportNivView.Items.Clear();
                listeSportNivView.Columns.Clear();

                // Créer les colonnes à partir des colonnes du DataTable
                foreach (DataColumn col in dt.Columns)
                {
                    listeSportNivView.Columns.Add(col.ColumnName);
                }

                // Ajouter les lignes
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item2 = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item2.SubItems.Add(row[i].ToString());
                    }
                    listeSportNivView.Items.Add(item2);
                }
                listeSportNivView.Visible = true;
                lblSport.Visible = true;
                lblSport.Text = $"Pour le sportif : {nom} {prenom} :";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBxNSport.Text == "" || cmbBxNouvNiv.SelectedItem == null)
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
                    //Récupération de l'id du sportif sélectionné
                    MySqlCommand cmd2 = new MySqlCommand("Select id from Sportif where nom = @nom AND prenom = @prenom AND dateNais = @dateNais AND rue = @rue AND cp = @cp AND ville = @ville");
                    cmd2.Parameters.AddWithValue("@nom", nom);
                    cmd2.Parameters.AddWithValue("@prenom", prenom);
                    cmd2.Parameters.AddWithValue("@dateNais", dateNais);
                    cmd2.Parameters.AddWithValue("@rue", rue);
                    cmd2.Parameters.AddWithValue("@cp", cp);
                    cmd2.Parameters.AddWithValue("@ville", ville);
                    cmd2.Connection = cnx;
                    //exécution de la requête et récupération du résultat
                    string idSportif = cmd2.ExecuteScalar().ToString();
                    //Récupération de l'id du sport sélectionné
                    MySqlCommand cmd3 = new MySqlCommand("Select id from Sport where lib = @lib");
                    cmd3.Parameters.AddWithValue("@lib", txtBxNSport.Text);
                    cmd3.Connection = cnx;
                    if (cmd3.ExecuteScalar() == null)
                    {
                        MySqlCommand cmd4 = new MySqlCommand("Insert into Sport (lib) values (@lib)");
                        cmd4.Parameters.AddWithValue("@lib", txtBxNSport.Text);
                        cmd4.Connection = cnx;
                        cmd4.ExecuteNonQuery();
                    }
                    //exécution de la requête et récupération du résultat
                    string idSport = cmd3.ExecuteScalar().ToString();
                    //verif si il existe déjà
                    MySqlCommand cmd5 = new MySqlCommand("Select * From Pratiquer_Sport Where idSportif = @idSportif AND idSport = @idSport");
                    cmd5.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd5.Parameters.AddWithValue("@idSport", idSport);
                    cmd5.Connection = cnx;
                    cmd5.ExecuteNonQuery();
                    if (cmd5.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Le niveau existe déjà pour ce sportif et ce sport ! Pour modifier le niveau, veuillez utiliser le bouton 'Modifier le niveau du sport sélectionné'");
                    }
                    else
                    {
                        //insertion dans la table Pratiquer_Sport
                        cmd.CommandText = "Insert into Pratiquer_Sport (idSportif, idSport, nivExp) values (@idSportif, @idSport, @nivExp)";
                        cmd.Parameters.AddWithValue("@idSportif", idSportif);
                        cmd.Parameters.AddWithValue("@idSport", idSport);
                        cmd.Parameters.AddWithValue("@nivExp", cmbBxNouvNiv.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le niveau a été ajouté avec succès !");

                    }
                }
                cmbBxNouvNiv.SelectedItem = null;
                txtBxNSport.Clear();
                FrmModifNivSport_Load(sender, e);
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (listeSportNivView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sport et un niveau à modifier !");
            }
            else
            {
                lblNivP.Visible = true;
                lblSportP.Visible = true;
                //txtBxSport.Enabled = true;
                cmbBxNiv.Enabled = true;
                txtBxSport.Visible = true;
                cmbBxNiv.Visible = true;
                txtBxSport.Text = listeSportNivView.SelectedItems[0].SubItems[1].Text;
                cmbBxNiv.SelectedItem = listeSportNivView.SelectedItems[0].SubItems[0].Text;
                btnValMod.Visible = true;
                btnValMod.Enabled = true;
                btnValSup.Enabled = false;
            }
        }

        private void btnValMod_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("Update Pratiquer_Sport Set nivExp = @nivExp Where idSportif = @idSportif AND idSport = @idSport");
                cmd.Connection = cnx;
                if (txtBxSport.Text == "" || cmbBxNiv.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand("Select id from Sportif where nom = @nom AND prenom = @prenom AND dateNais = @dateNais AND rue = @rue AND cp = @cp AND ville = @ville");
                    cmd2.Connection = cnx;
                    cmd2.Parameters.AddWithValue("@nom", nom);
                    cmd2.Parameters.AddWithValue("@prenom", prenom);
                    cmd2.Parameters.AddWithValue("@dateNais", dateNais);
                    cmd2.Parameters.AddWithValue("@rue", rue);
                    cmd2.Parameters.AddWithValue("@cp", cp);
                    cmd2.Parameters.AddWithValue("@ville", ville);
                    //récup
                    string idSportif = cmd2.ExecuteScalar().ToString();

                    MySqlCommand cmd3 = new MySqlCommand("Select id from Sport where lib = @lib");
                    cmd3.Parameters.AddWithValue("@lib", txtBxSport.Text);
                    cmd3.Connection = cnx;
                    //exécution de la requête et récupération du résultat
                    string idSport = cmd3.ExecuteScalar().ToString();

                    //verif si le niv existe déjà
                    MySqlCommand cmd5 = new MySqlCommand("Select nivExp From Pratiquer_Sport Where idSportif = @idSportif AND idSport = @idSport");
                    cmd5.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd5.Parameters.AddWithValue("@idSport", idSport);
                    cmd5.Connection = cnx;

                    string nivExpActuel = cmd5.ExecuteScalar().ToString();

                    if (nivExpActuel == cmbBxNiv.SelectedItem.ToString())
                    {
                        MessageBox.Show("Le niveau est déjà le bon pour ce sport !");
                    }
                    else
                    {
                        string nouvNiv = cmbBxNiv.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@idSportif", idSportif);
                        cmd.Parameters.AddWithValue("@idSport", idSport);
                        cmd.Parameters.AddWithValue("@nivExp", nouvNiv);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show($"idSportif: {idSportif}, idSport: {idSport}, nouvNiv: {nouvNiv}");
                        MessageBox.Show("Le niveau a été mis à jour avec succès !");
                        cmbBxNiv.SelectedItem = null;
                        txtBxSport.Clear();
                        //refresh
                        FrmModifNivSport_Load(sender, e);

                        //réinitialisation des textes.
                        lblNivP.Visible = false;
                        lblSportP.Visible = false;
                        cmbBxNiv.Enabled = false;
                        txtBxSport.Visible = false;
                        cmbBxNiv.Visible = false;
                        btnValMod.Visible = false;
                        btnValSup.Visible = false;
                        btnValMod.Enabled = false;

                    }
                }


            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (listeSportNivView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sport et un niveau à modifier !");
            }
            else
            {
                lblNivP.Visible = true;
                lblSportP.Visible = true;
                //txtBxSport.Enabled = true;
                cmbBxNiv.Enabled = false;
                txtBxSport.Visible = true;
                cmbBxNiv.Visible = true;
                txtBxSport.Text = listeSportNivView.SelectedItems[0].SubItems[1].Text;
                cmbBxNiv.SelectedItem = listeSportNivView.SelectedItems[0].SubItems[0].Text;
                btnValSup.Visible = true;
                btnValSup.Enabled = true;
                btnValMod.Enabled = false;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValSup_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from Pratiquer_Sport Where idSportif = @idSportif AND idSport = @idSport AND nivExp = @nivExp");
                cmd.Connection = cnx;
                if (txtBxSport.Text == "" || cmbBxNiv.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    //id sportif récup
                    MySqlCommand cmd2 = new MySqlCommand("Select id from Sportif where nom = @nom AND prenom = @prenom AND dateNais = @dateNais AND rue = @rue AND cp = @cp AND ville = @ville");
                    cmd2.Connection = cnx;
                    cmd2.Parameters.AddWithValue("@nom", nom);
                    cmd2.Parameters.AddWithValue("@prenom", prenom);
                    cmd2.Parameters.AddWithValue("@dateNais", dateNais);
                    cmd2.Parameters.AddWithValue("@rue", rue);
                    cmd2.Parameters.AddWithValue("@cp", cp);
                    cmd2.Parameters.AddWithValue("@ville", ville);
                    //exécution de la requête et récupération du résultat
                    string idSportif = cmd2.ExecuteScalar().ToString();

                    //id sport récup
                    MySqlCommand cmd3 = new MySqlCommand("Select id from Sport where lib = @lib");
                    cmd3.Parameters.AddWithValue("@lib", txtBxSport.Text);
                    cmd3.Connection = cnx;
                    //exécution de la requête et récupération du résultat
                    string idSport = cmd3.ExecuteScalar().ToString();

                    //niv récup
                    MySqlCommand cmd5 = new MySqlCommand("Select nivExp From Pratiquer_Sport Where idSportif = @idSportif AND idSport = @idSport");
                    cmd5.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd5.Parameters.AddWithValue("@idSport", idSport);
                    cmd5.Connection = cnx;

                    string nivExp = cmd5.ExecuteScalar().ToString();
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette pratique de sport ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@idSportif", idSportif);
                        cmd.Parameters.AddWithValue("@idSport", idSport);
                        cmd.Parameters.AddWithValue("@nivExp", nivExp);
                        cmd.ExecuteNonQuery();
                        cmbBxNiv.SelectedItem = null;
                        txtBxSport.Clear();
                        //refresh
                        FrmModifNivSport_Load(sender, e);
                        //reset textes
                        lblNivP.Visible = false;
                        lblSportP.Visible = false;
                        cmbBxNiv.Enabled = false;
                        txtBxSport.Visible = false;
                        cmbBxNiv.Visible = false;
                        btnValSup.Visible = false;
                        btnValSup.Enabled = false;
                        btnValMod.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Suppression annulée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}