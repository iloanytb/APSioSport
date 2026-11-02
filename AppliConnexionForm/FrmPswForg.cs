using BiblioMetierSportif;
using BiblioADOSportif;
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
            List<Utilisateur> lesUtilisateurs = UtilisateurADO.GetAllList();
            Utilisateur Lutilisateur = new Utilisateur(txtBxLog.Text, txtBxPsw.Text);
            if (string.IsNullOrEmpty(txtBxLog.Text) || string.IsNullOrEmpty(txtBxPsw.Text) || string.IsNullOrEmpty(txtBxConf.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
                else
                {
                    foreach (Utilisateur unUtilisateur in lesUtilisateurs)
                    {
                        if (unUtilisateur.Login == Lutilisateur.Login && unUtilisateur.Psw == Lutilisateur.Psw)
                        {
                            MessageBox.Show("Ceci est déjà votre mot de passe !");
                            txtBxPsw.Clear();
                            txtBxConf.Clear();
                        }
                        else
                        {
                            List<string> lesLogins = UtilisateurADO.GetAllLogins();
                            int cpt = 0;
                            foreach (string login in lesLogins)
                            {
                                if (login != Lutilisateur.Login)
                                {
                                    cpt++;
                                }
                            }
                            if (cpt >= lesLogins.Count)
                            {
                                MessageBox.Show("Ce login n'est pas le bon !");
                                txtBxPsw.Clear();
                                txtBxConf.Clear();
                            }
                            else
                            {
                                    UtilisateurADO.Update(Lutilisateur);
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