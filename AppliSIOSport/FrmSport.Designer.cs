namespace AppliSIOSport
{
    partial class frmSport
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
            this.listeCrit = new System.Windows.Forms.ListBox();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.btnRech = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.listeResView = new System.Windows.Forms.ListView();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnAffSport = new System.Windows.Forms.Button();
            this.lisResAffView = new System.Windows.Forms.ListView();
            this.lblSportif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeCrit
            // 
            this.listeCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listeCrit.FormattingEnabled = true;
            this.listeCrit.ItemHeight = 25;
            this.listeCrit.Location = new System.Drawing.Point(12, 12);
            this.listeCrit.Name = "listeCrit";
            this.listeCrit.Size = new System.Drawing.Size(341, 204);
            this.listeCrit.TabIndex = 0;
            this.listeCrit.SelectedIndexChanged += new System.EventHandler(this.listeCrit_SelectedIndexChanged);
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBxSearch.Location = new System.Drawing.Point(438, 12);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(219, 32);
            this.txtBxSearch.TabIndex = 1;
            // 
            // btnRech
            // 
            this.btnRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRech.Location = new System.Drawing.Point(438, 78);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(219, 69);
            this.btnRech.TabIndex = 2;
            this.btnRech.Text = "Rechercher";
            this.btnRech.UseVisualStyleBackColor = true;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnQuit.Location = new System.Drawing.Point(12, 767);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(173, 70);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUITTER";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // listeResView
            // 
            this.listeResView.HideSelection = false;
            this.listeResView.Location = new System.Drawing.Point(12, 296);
            this.listeResView.Name = "listeResView";
            this.listeResView.Size = new System.Drawing.Size(814, 339);
            this.listeResView.TabIndex = 4;
            this.listeResView.UseCompatibleStateImageBehavior = false;
            this.listeResView.SelectedIndexChanged += new System.EventHandler(this.listeResView_SelectedIndexChanged);
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRes.Location = new System.Drawing.Point(12, 270);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(317, 23);
            this.lblRes.TabIndex = 21;
            this.lblRes.Text = "Résultat :";
            // 
            // btnAffSport
            // 
            this.btnAffSport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAffSport.Location = new System.Drawing.Point(12, 641);
            this.btnAffSport.Name = "btnAffSport";
            this.btnAffSport.Size = new System.Drawing.Size(275, 93);
            this.btnAffSport.TabIndex = 22;
            this.btnAffSport.Text = "Afficher Sports et Niveaux";
            this.btnAffSport.UseVisualStyleBackColor = false;
            this.btnAffSport.Click += new System.EventHandler(this.btnAffSport_Click);
            // 
            // lisResAffView
            // 
            this.lisResAffView.HideSelection = false;
            this.lisResAffView.Location = new System.Drawing.Point(867, 498);
            this.lisResAffView.Name = "lisResAffView";
            this.lisResAffView.Size = new System.Drawing.Size(549, 339);
            this.lisResAffView.TabIndex = 23;
            this.lisResAffView.UseCompatibleStateImageBehavior = false;
            this.lisResAffView.Visible = false;
            // 
            // lblSportif
            // 
            this.lblSportif.AutoSize = true;
            this.lblSportif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSportif.Location = new System.Drawing.Point(862, 469);
            this.lblSportif.Name = "lblSportif";
            this.lblSportif.Size = new System.Drawing.Size(194, 26);
            this.lblSportif.TabIndex = 25;
            this.lblSportif.Text = "[Sportif concerné] :";
            this.lblSportif.Visible = false;
            // 
            // frmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 849);
            this.Controls.Add(this.lblSportif);
            this.Controls.Add(this.lisResAffView);
            this.Controls.Add(this.btnAffSport);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.listeResView);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.listeCrit);
            this.Name = "frmSport";
            this.Text = "Consultation des Sportifs";
            this.Load += new System.EventHandler(this.frmSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeCrit;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListView listeResView;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnAffSport;
        private System.Windows.Forms.ListView lisResAffView;
        private System.Windows.Forms.Label lblSportif;
    }
}

