using BiblioADOSportif;
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

namespace AppliSIOSport
{
    public partial class frmSport : Form
    {
        public frmSport()
        {
            InitializeComponent();
        }
        private string GetColonneSQL(string lib)
        {
            switch (lib)
            {
                case "Ville":
                    return "ville";
                case "Prénom":
                    return "prenom";
                case "Nom de famille":
                    return "nom";
                default:
                    return null;
            }
        }
        private void frmSport_Load(object sender, EventArgs e)
        {
            listeCrit.Items.Add("Ville");
            listeCrit.Items.Add("Prénom");
            listeCrit.Items.Add("Nom de famille");
            listeResView.MultiSelect = false;
            btnRech_Click(sender, e);

        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (listeCrit.SelectedItem != null && txtBxSearch.Text != "")
            {
                string param = GetColonneSQL(listeCrit.SelectedItem.ToString());
                string recherche = txtBxSearch.Text;
                dt = SportifADO.GetByOther(param, recherche);
            }
            else
            {
                dt = SportifADO.GetAll();
            }

            //Configuration du ListView
            listeResView.View = View.Details;
                listeResView.GridLines = true;
                listeResView.FullRowSelect = true;
                listeResView.Items.Clear();
                listeResView.Columns.Clear();

                // Créer les colonnes à partir des colonnes du DataTable
                foreach (DataColumn col in dt.Columns)
                {
                    listeResView.Columns.Add(col.ColumnName);
                }

                // Ajouter les lignes
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listeResView.Items.Add(item);
                }
            }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeResView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAffSport_Click(object sender, EventArgs e)
        {
            if (listeResView.SelectedItems.Count > 0)
            {
                ListViewItem item = listeResView.SelectedItems[0];
                int id = int.Parse(item.Text);
                string nm = item.SubItems[1].Text;
                string pm = item.SubItems[2].Text;

                DataTable dt = Pratiquer_SportADO.GetSportNivById(id);

            //Configuration du ListView
            lisResAffView.View = View.Details;
                    lisResAffView.GridLines = true;
                    lisResAffView.FullRowSelect = true;
                    lisResAffView.Items.Clear();
                    lisResAffView.Columns.Clear();

                    // Créer les colonnes à partir des colonnes du DataTable
                    foreach (DataColumn col in dt.Columns)
                    {
                        lisResAffView.Columns.Add(col.ColumnName);
                    }

                    // Ajouter les lignes
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item2 = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            item2.SubItems.Add(row[i].ToString());
                        }
                        lisResAffView.Items.Add(item2);
                    }
                    lisResAffView.Visible = true;
                    lblSportif.Visible = true;
                    lblSportif.Text = $"Niveau de {nm} {pm} selon le sport : ";
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un sportif dans la fenêtre de résultat.");
                }
                
            }

        private void listeCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
