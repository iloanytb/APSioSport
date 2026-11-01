namespace AppliFormGestionSIOSport
{
    partial class FrmGest
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.txtBxPrenom = new System.Windows.Forms.TextBox();
            this.txtBxRue = new System.Windows.Forms.TextBox();
            this.txtBxCP = new System.Windows.Forms.TextBox();
            this.txtBxVille = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBxSport = new System.Windows.Forms.ListBox();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPren = new System.Windows.Forms.Label();
            this.lblDateNais = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.dateTmNais = new System.Windows.Forms.DateTimePicker();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnValMod = new System.Windows.Forms.Button();
            this.btnModifSprtNv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxNom
            // 
            this.txtBxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxNom.Location = new System.Drawing.Point(342, 478);
            this.txtBxNom.MaxLength = 15;
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(200, 32);
            this.txtBxNom.TabIndex = 0;
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxPrenom.Location = new System.Drawing.Point(342, 516);
            this.txtBxPrenom.MaxLength = 20;
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(200, 32);
            this.txtBxPrenom.TabIndex = 1;
            // 
            // txtBxRue
            // 
            this.txtBxRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxRue.Location = new System.Drawing.Point(342, 592);
            this.txtBxRue.MaxLength = 30;
            this.txtBxRue.Name = "txtBxRue";
            this.txtBxRue.Size = new System.Drawing.Size(200, 32);
            this.txtBxRue.TabIndex = 3;
            // 
            // txtBxCP
            // 
            this.txtBxCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxCP.Location = new System.Drawing.Point(395, 630);
            this.txtBxCP.MaxLength = 5;
            this.txtBxCP.Name = "txtBxCP";
            this.txtBxCP.Size = new System.Drawing.Size(147, 32);
            this.txtBxCP.TabIndex = 4;
            // 
            // txtBxVille
            // 
            this.txtBxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxVille.Location = new System.Drawing.Point(342, 668);
            this.txtBxVille.MaxLength = 20;
            this.txtBxVille.Name = "txtBxVille";
            this.txtBxVille.Size = new System.Drawing.Size(200, 32);
            this.txtBxVille.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.Location = new System.Drawing.Point(927, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 86);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBxSport
            // 
            this.lstBxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lstBxSport.FormattingEnabled = true;
            this.lstBxSport.Location = new System.Drawing.Point(12, 4);
            this.lstBxSport.Name = "lstBxSport";
            this.lstBxSport.Size = new System.Drawing.Size(1069, 355);
            this.lstBxSport.TabIndex = 9;
            // 
            // btnUpdt
            // 
            this.btnUpdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnUpdt.Location = new System.Drawing.Point(1087, 104);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(231, 86);
            this.btnUpdt.TabIndex = 10;
            this.btnUpdt.Text = "Modifier";
            this.btnUpdt.UseVisualStyleBackColor = true;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDel.Location = new System.Drawing.Point(1087, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(231, 86);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Supprimer";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNom.Location = new System.Drawing.Point(548, 478);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = ": Nom";
            // 
            // lblPren
            // 
            this.lblPren.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPren.Location = new System.Drawing.Point(548, 525);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(218, 23);
            this.lblPren.TabIndex = 13;
            this.lblPren.Text = ": Prénom";
            // 
            // lblDateNais
            // 
            this.lblDateNais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDateNais.Location = new System.Drawing.Point(548, 563);
            this.lblDateNais.Name = "lblDateNais";
            this.lblDateNais.Size = new System.Drawing.Size(218, 23);
            this.lblDateNais.TabIndex = 14;
            this.lblDateNais.Text = ": Date de Naissance";
            // 
            // lblRue
            // 
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRue.Location = new System.Drawing.Point(548, 601);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(266, 23);
            this.lblRue.TabIndex = 15;
            this.lblRue.Text = ": Numéro et nom de rue";
            // 
            // lblCP
            // 
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCP.Location = new System.Drawing.Point(548, 639);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(266, 23);
            this.lblCP.TabIndex = 16;
            this.lblCP.Text = ": Code Postal";
            // 
            // lblVille
            // 
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVille.Location = new System.Drawing.Point(548, 677);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(266, 23);
            this.lblVille.TabIndex = 17;
            this.lblVille.Text = ": Nom de la ville";
            // 
            // lblAdd
            // 
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAdd.Location = new System.Drawing.Point(437, 418);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(317, 23);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = "Ajouter/Modifier un sportif : ";
            // 
            // dateTmNais
            // 
            this.dateTmNais.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTmNais.Location = new System.Drawing.Point(342, 566);
            this.dateTmNais.MaxDate = new System.DateTime(2026, 10, 13, 0, 0, 0, 0);
            this.dateTmNais.MinDate = new System.DateTime(1925, 6, 11, 0, 0, 0, 0);
            this.dateTmNais.Name = "dateTmNais";
            this.dateTmNais.Size = new System.Drawing.Size(200, 20);
            this.dateTmNais.TabIndex = 21;
            this.dateTmNais.Value = new System.DateTime(2026, 10, 11, 0, 0, 0, 0);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnQuit.Location = new System.Drawing.Point(12, 753);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(173, 70);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "QUITTER";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnValMod
            // 
            this.btnValMod.Enabled = false;
            this.btnValMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnValMod.Location = new System.Drawing.Point(927, 510);
            this.btnValMod.Name = "btnValMod";
            this.btnValMod.Size = new System.Drawing.Size(231, 86);
            this.btnValMod.TabIndex = 24;
            this.btnValMod.Text = "Valider la Modification";
            this.btnValMod.UseVisualStyleBackColor = true;
            this.btnValMod.Visible = false;
            this.btnValMod.Click += new System.EventHandler(this.btnValMod_Click);
            // 
            // btnModifSprtNv
            // 
            this.btnModifSprtNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnModifSprtNv.Location = new System.Drawing.Point(1087, 196);
            this.btnModifSprtNv.Name = "btnModifSprtNv";
            this.btnModifSprtNv.Size = new System.Drawing.Size(231, 86);
            this.btnModifSprtNv.TabIndex = 25;
            this.btnModifSprtNv.Text = "Modifier les sports et niveau associé";
            this.btnModifSprtNv.UseVisualStyleBackColor = true;
            this.btnModifSprtNv.Click += new System.EventHandler(this.btnModifSprtNv_Click);
            // 
            // FrmGest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 835);
            this.Controls.Add(this.btnModifSprtNv);
            this.Controls.Add(this.btnValMod);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dateTmNais);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblDateNais);
            this.Controls.Add(this.lblPren);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.lstBxSport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxVille);
            this.Controls.Add(this.txtBxCP);
            this.Controls.Add(this.txtBxRue);
            this.Controls.Add(this.txtBxPrenom);
            this.Controls.Add(this.txtBxNom);
            this.Name = "FrmGest";
            this.Text = "Gestion des sportifs";
            this.Load += new System.EventHandler(this.FrmGest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNom;
        private System.Windows.Forms.TextBox txtBxPrenom;
        private System.Windows.Forms.TextBox txtBxRue;
        private System.Windows.Forms.TextBox txtBxCP;
        private System.Windows.Forms.TextBox txtBxVille;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBxSport;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.Label lblDateNais;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.DateTimePicker dateTmNais;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnValMod;
        private System.Windows.Forms.Button btnModifSprtNv;
    }
}

