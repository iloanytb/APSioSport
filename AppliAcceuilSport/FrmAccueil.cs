using AppliConnexionForm;
using AppliFormGestionSIOSport;
using AppliSIOSport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliAcceuilSport
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void consultationSportifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSport unObjetSport = new frmSport();
            unObjetSport.Show();
        }

        private void gestionDesSportifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCnx unObjCnx = new FrmCnx();
            unObjCnx.Show();
            //FrmGest unObjGest = new FrmGest();
            //unObjGest.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {

        }
    }
}
