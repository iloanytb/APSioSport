using AppliFormGestionSIOSport;
using BiblioADOSportif;
using BiblioMetierSportif;
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
            List<Utilisateur> lesUtilisateurs = UtilisateurADO.GetAllList();
            if (txtBxLog.Text == "" || txtBxPsw.Text == "" || txtBxConfPass.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                foreach (Utilisateur unUtilisateur in lesUtilisateurs)
                {
                    if (unUtilisateur.Login == txtBxLog.Text)
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
                                Utilisateur unNouvelUtilisateur = new Utilisateur(txtBxLog.Text, txtBxPsw.Text);
                                UtilisateurADO.Insert(unNouvelUtilisateur);
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
