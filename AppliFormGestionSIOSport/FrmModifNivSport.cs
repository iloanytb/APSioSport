using BiblioADOSportif;
using BiblioMetierSportif;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
            List<Sportif> lesSportifs = SportifADO.GetAllList();
            foreach (Sportif unSportif in lesSportifs)
            {
                if (unSportif.Nom == nom && unSportif.Prenom == prenom && unSportif.DateNais == dateNais && unSportif.Rue == rue && unSportif.Cp == cp && unSportif.Ville == ville)
                {
                    //Récupération de l'id du sportif sélectionné
                    int idS = unSportif.Id;
                    DataTable data = Pratiquer_SportADO.GetSportNivById(idS);
                    //Configuration du ListView
                    listeSportNivView.View = View.Details;
                    listeSportNivView.GridLines = true;
                    listeSportNivView.FullRowSelect = true;
                    listeSportNivView.Items.Clear();
                    listeSportNivView.Columns.Clear();
                    // Créer les colonnes à partir des colonnes du DataTable
                    foreach (DataColumn col in data.Columns)
                    {
                        listeSportNivView.Columns.Add(col.ColumnName);
                    }
                    // Ajouter les lignes
                    foreach (DataRow row in data.Rows)
                    {
                        ListViewItem item2 = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < data.Columns.Count; i++)
                        {
                            item2.SubItems.Add(row[i].ToString());
                        }
                        listeSportNivView.Items.Add(item2);
                    }
                }
            }
                listeSportNivView.Visible = true;
                lblSport.Visible = true;
                lblSport.Text = $"Pour le sportif : {nom} {prenom} :";
            }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBxNSport.Text == "" || cmbBxNouvNiv.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                List<Sportif> lesSportifs = SportifADO.GetAllList();
                List<Sport> lesSports = SportADO.GetAllList();
                List<Pratiquer_Sport> lesPratiques = Pratiquer_SportADO.GetAll();
                int idS = 0;
                foreach (Sportif unSportif in lesSportifs)
                {
                    if (unSportif.Nom == nom && unSportif.Prenom == prenom && unSportif.DateNais == dateNais && unSportif.Rue == rue && unSportif.Cp == cp && unSportif.Ville == ville)
                    {
                        //Récupération de l'id du sportif sélectionné
                        idS = unSportif.Id;
                    }
                }
                int idSport = 0;
                foreach (Sport unSport in lesSports)
                {
                    if (unSport.Lib == txtBxNSport.Text)
                    {
                        //Récupération de l'id du sport sélectionné
                        idSport = unSport.Id;
                    }
                    else
                    {
                        //Récupération de l'id du sport sélectionné
                        idSport = 0;
                    }
                }
                if (idSport == 0) 
                { 
                    Sport unNouveauSport = new Sport(txtBxNSport.Text);
                    SportADO.Insert(unNouveauSport);
                    lesSports = SportADO.GetAllList();
                    foreach (Sport unSport in lesSports)
                    {
                        if (unSport.Lib == unNouveauSport.Lib)
                        {
                            //Récupération de l'id du sport sélectionné
                            idSport = unSport.Id;
                        }
                    }
                }
                Pratiquer_Sport pratique_test = new Pratiquer_Sport(idSport, idS);
                if(lesPratiques.Contains(pratique_test))
                {
                    MessageBox.Show("Le niveau existe déjà pour ce sportif et ce sport ! Pour modifier le niveau, veuillez utiliser le bouton 'Modifier le niveau du sport sélectionné'");
                }
                else
                {
                    string nivExp = cmbBxNouvNiv.SelectedItem.ToString();
                    Pratiquer_Sport unePratique = new Pratiquer_Sport(idSport, idS, nivExp);
                    Pratiquer_SportADO.Insert(unePratique);
                }
            }
                cmbBxNouvNiv.SelectedItem = null;
                txtBxNSport.Clear();
                FrmModifNivSport_Load(sender, e);
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
                if (txtBxSport.Text == "" || cmbBxNiv.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    List<Sportif> lesSportifs = SportifADO.GetAllList();
                    List<Sport> lesSports = SportADO.GetAllList();
                    List<Pratiquer_Sport> lesPratiques = Pratiquer_SportADO.GetAll();
                    int idSportif = 0;
                    foreach (Sportif unSportif in lesSportifs)
                    {
                        if (unSportif.Nom == nom && unSportif.Prenom == prenom && unSportif.DateNais == dateNais && unSportif.Rue == rue && unSportif.Cp == cp && unSportif.Ville == ville)
                        {
                            //Récupération de l'id du sportif sélectionné
                            idSportif = unSportif.Id;
                        }
                    }
                    int idSport = 0;
                    foreach (Sport unSport in lesSports)
                    {
                        if (unSport.Lib == txtBxSport.Text)
                        {
                            //Récupération de l'id du sport sélectionné
                            idSport = unSport.Id;
                        }
                    }
                    string nivExpActuel = "";
                    foreach (Pratiquer_Sport unePratique in lesPratiques)
                    {
                        if (unePratique.IdSportif == idSportif && unePratique.IdSport == idSport)
                        {
                            //Récupération du niveau actuel
                            nivExpActuel = unePratique.NivExp;
                        }
                    }
                    
                    if (nivExpActuel == cmbBxNiv.SelectedItem.ToString())
                    {
                        MessageBox.Show("Le niveau est déjà le bon pour ce sport !");
                    }
                    else
                    {
                        string nouvNiv = cmbBxNiv.SelectedItem.ToString();
                        Pratiquer_Sport unePratiqueMiseAJour = new Pratiquer_Sport(idSport, idSportif, nouvNiv);
                        Pratiquer_SportADO.Update(unePratiqueMiseAJour);
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
            
                if (txtBxSport.Text == "" || cmbBxNiv.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    //id sportif récup
                    List<Sportif> lesSportifs = SportifADO.GetAllList();
                    List<Sport> lesSports = SportADO.GetAllList();
                    List<Pratiquer_Sport> lesPratiques = Pratiquer_SportADO.GetAll();
                    int idSportif = 0;
                    foreach (Sportif unSportif in lesSportifs)
                    {
                        if (unSportif.Nom == nom && unSportif.Prenom == prenom && unSportif.DateNais == dateNais && unSportif.Rue == rue && unSportif.Cp == cp && unSportif.Ville == ville)
                        {
                            //Récupération de l'id du sportif sélectionné
                            idSportif = unSportif.Id;
                        }
                    }
                    int idSport = 0;
                    foreach (Sport unSport in lesSports)
                    {
                        if (unSport.Lib == txtBxSport.Text)
                        {
                            //Récupération de l'id du sport sélectionné
                            idSport = unSport.Id;
                        }
                    }
                    string nivExp = "";
                    foreach (Pratiquer_Sport unePratique in lesPratiques)
                    {
                        if (unePratique.IdSportif == idSportif && unePratique.IdSport == idSport)
                        {
                            //Récupération du niveau actuel
                            nivExp = unePratique.NivExp;
                        }
                    }
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette pratique de sport ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Pratiquer_Sport unePratiqueASupprimer = new Pratiquer_Sport(idSport, idSportif, nivExp);
                        Pratiquer_SportADO.Delete(unePratiqueASupprimer);
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