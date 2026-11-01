namespace AppliFormGestionSIOSport
{
    partial class FrmModifNivSport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listeSportNivView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSport = new System.Windows.Forms.Label();
            this.txtBxSport = new System.Windows.Forms.TextBox();
            this.cmbBxNiv = new System.Windows.Forms.ComboBox();
            this.lblSportP = new System.Windows.Forms.Label();
            this.lblNivP = new System.Windows.Forms.Label();
            this.lblNiv = new System.Windows.Forms.Label();
            this.lblNSport = new System.Windows.Forms.Label();
            this.cmbBxNouvNiv = new System.Windows.Forms.ComboBox();
            this.txtBxNSport = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnValMod = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnValSup = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeSportNivView
            // 
            this.listeSportNivView.HideSelection = false;
            this.listeSportNivView.Location = new System.Drawing.Point(12, 68);
            this.listeSportNivView.MultiSelect = false;
            this.listeSportNivView.Name = "listeSportNivView";
            this.listeSportNivView.Size = new System.Drawing.Size(516, 315);
            this.listeSportNivView.TabIndex = 0;
            this.listeSportNivView.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.Location = new System.Drawing.Point(865, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 63);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter le sport";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSport
            // 
            this.lblSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSport.Location = new System.Drawing.Point(12, 30);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(388, 35);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Pour le sportif : [Sportif]";
            // 
            // txtBxSport
            // 
            this.txtBxSport.Enabled = false;
            this.txtBxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxSport.Location = new System.Drawing.Point(865, 455);
            this.txtBxSport.MaxLength = 10;
            this.txtBxSport.Name = "txtBxSport";
            this.txtBxSport.Size = new System.Drawing.Size(264, 32);
            this.txtBxSport.TabIndex = 3;
            this.txtBxSport.Visible = false;
            // 
            // cmbBxNiv
            // 
            this.cmbBxNiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxNiv.Enabled = false;
            this.cmbBxNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbBxNiv.FormattingEnabled = true;
            this.cmbBxNiv.Items.AddRange(new object[] {
            "Professionnel",
            "Avancé",
            "Confirmé",
            "Débutant"});
            this.cmbBxNiv.Location = new System.Drawing.Point(865, 526);
            this.cmbBxNiv.Name = "cmbBxNiv";
            this.cmbBxNiv.Size = new System.Drawing.Size(264, 33);
            this.cmbBxNiv.TabIndex = 4;
            this.cmbBxNiv.Visible = false;
            // 
            // lblSportP
            // 
            this.lblSportP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSportP.Location = new System.Drawing.Point(642, 458);
            this.lblSportP.Name = "lblSportP";
            this.lblSportP.Size = new System.Drawing.Size(201, 35);
            this.lblSportP.TabIndex = 5;
            this.lblSportP.Text = "Sport sélectionné :";
            this.lblSportP.Visible = false;
            // 
            // lblNivP
            // 
            this.lblNivP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNivP.Location = new System.Drawing.Point(638, 529);
            this.lblNivP.Name = "lblNivP";
            this.lblNivP.Size = new System.Drawing.Size(205, 35);
            this.lblNivP.TabIndex = 6;
            this.lblNivP.Text = "Niveau de ce sport :";
            this.lblNivP.Visible = false;
            // 
            // lblNiv
            // 
            this.lblNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNiv.Location = new System.Drawing.Point(621, 202);
            this.lblNiv.Name = "lblNiv";
            this.lblNiv.Size = new System.Drawing.Size(205, 35);
            this.lblNiv.TabIndex = 10;
            this.lblNiv.Text = "Niveau de ce sport :";
            // 
            // lblNSport
            // 
            this.lblNSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNSport.Location = new System.Drawing.Point(625, 131);
            this.lblNSport.Name = "lblNSport";
            this.lblNSport.Size = new System.Drawing.Size(201, 35);
            this.lblNSport.TabIndex = 9;
            this.lblNSport.Text = "Nouveau sport :";
            // 
            // cmbBxNouvNiv
            // 
            this.cmbBxNouvNiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxNouvNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbBxNouvNiv.FormattingEnabled = true;
            this.cmbBxNouvNiv.Items.AddRange(new object[] {
            "Professionnel",
            "Avancé",
            "Confirmé",
            "Débutant"});
            this.cmbBxNouvNiv.Location = new System.Drawing.Point(848, 199);
            this.cmbBxNouvNiv.Name = "cmbBxNouvNiv";
            this.cmbBxNouvNiv.Size = new System.Drawing.Size(264, 33);
            this.cmbBxNouvNiv.TabIndex = 8;
            // 
            // txtBxNSport
            // 
            this.txtBxNSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxNSport.Location = new System.Drawing.Point(848, 128);
            this.txtBxNSport.MaxLength = 10;
            this.txtBxNSport.Name = "txtBxNSport";
            this.txtBxNSport.Size = new System.Drawing.Size(264, 32);
            this.txtBxNSport.TabIndex = 7;
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnModif.Location = new System.Drawing.Point(17, 389);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(511, 63);
            this.btnModif.TabIndex = 11;
            this.btnModif.Text = "Modifier le niveau du sport sélectionné";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnValMod
            // 
            this.btnValMod.Enabled = false;
            this.btnValMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnValMod.Location = new System.Drawing.Point(647, 594);
            this.btnValMod.Name = "btnValMod";
            this.btnValMod.Size = new System.Drawing.Size(216, 63);
            this.btnValMod.TabIndex = 12;
            this.btnValMod.Text = "Valider la modification";
            this.btnValMod.UseVisualStyleBackColor = true;
            this.btnValMod.Visible = false;
            this.btnValMod.Click += new System.EventHandler(this.btnValMod_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSupp.Location = new System.Drawing.Point(17, 458);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(511, 63);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer la pratique de ce sport par le sportif";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnValSup
            // 
            this.btnValSup.Enabled = false;
            this.btnValSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnValSup.Location = new System.Drawing.Point(869, 594);
            this.btnValSup.Name = "btnValSup";
            this.btnValSup.Size = new System.Drawing.Size(216, 63);
            this.btnValSup.TabIndex = 14;
            this.btnValSup.Text = "Valider la suppression";
            this.btnValSup.UseVisualStyleBackColor = true;
            this.btnValSup.Visible = false;
            this.btnValSup.Click += new System.EventHandler(this.btnValSup_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnQuit.Location = new System.Drawing.Point(12, 614);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(143, 48);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "QUITTER";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmModifNivSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 674);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnValSup);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnValMod);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lblNiv);
            this.Controls.Add(this.lblNSport);
            this.Controls.Add(this.cmbBxNouvNiv);
            this.Controls.Add(this.txtBxNSport);
            this.Controls.Add(this.lblNivP);
            this.Controls.Add(this.lblSportP);
            this.Controls.Add(this.cmbBxNiv);
            this.Controls.Add(this.txtBxSport);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listeSportNivView);
            this.Name = "FrmModifNivSport";
            this.Text = "Modifier les niveaux du sportif";
            this.Load += new System.EventHandler(this.FrmModifNivSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listeSportNivView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.TextBox txtBxSport;
        private System.Windows.Forms.ComboBox cmbBxNiv;
        private System.Windows.Forms.Label lblSportP;
        private System.Windows.Forms.Label lblNivP;
        private System.Windows.Forms.Label lblNiv;
        private System.Windows.Forms.Label lblNSport;
        private System.Windows.Forms.ComboBox cmbBxNouvNiv;
        private System.Windows.Forms.TextBox txtBxNSport;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnValMod;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnValSup;
        private System.Windows.Forms.Button btnQuit;
    }
}