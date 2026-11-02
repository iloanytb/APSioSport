using AppliFormGestionSIOSport;
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
            List<Utilisateur> lesUtilisateurs = UtilisateurADO.GetAllList();
            int cpt = 0;
            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if (unUtilisateur.Login == txtBxLog.Text && unUtilisateur.Psw == txtBxMdp.Text)
                {
                    MessageBox.Show("Connexion réussie !");
                    FrmGest unObjGest = new FrmGest();
                    unObjGest.Show();
                    this.Close();
                }
                else 
                {
                    cpt++;
                }
            }
            if(cpt >= lesUtilisateurs.Count)
            {
                    MessageBox.Show("Mauvais login ou mot de passe. (Si vous n'avez pas de compte, appuyez sur le bouton 'Créer un compte')");
                    MessageBox.Show("Si vous voulez changer de mot de passe, appuyez sur le texte 'Mot de passe oublié ?'");
                    txtBxMdp.Clear();
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
