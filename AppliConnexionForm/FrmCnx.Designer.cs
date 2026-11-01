namespace AppliConnexionForm
{
    partial class FrmCnx
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBxLog = new System.Windows.Forms.TextBox();
            this.txtBxMdp = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblPswForg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(345, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pour accéder à ce contenu, veuillez vous connecter :";
            // 
            // btnVal
            // 
            this.btnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnVal.Location = new System.Drawing.Point(691, 413);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(175, 64);
            this.btnVal.TabIndex = 1;
            this.btnVal.Text = "CONFIRMER";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.Location = new System.Drawing.Point(350, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 64);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Créer un compte";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBxLog
            // 
            this.txtBxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxLog.Location = new System.Drawing.Point(350, 189);
            this.txtBxLog.MaxLength = 15;
            this.txtBxLog.Name = "txtBxLog";
            this.txtBxLog.Size = new System.Drawing.Size(516, 44);
            this.txtBxLog.TabIndex = 3;
            // 
            // txtBxMdp
            // 
            this.txtBxMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxMdp.Location = new System.Drawing.Point(350, 291);
            this.txtBxMdp.MaxLength = 50;
            this.txtBxMdp.Name = "txtBxMdp";
            this.txtBxMdp.PasswordChar = '*';
            this.txtBxMdp.Size = new System.Drawing.Size(516, 44);
            this.txtBxMdp.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnQuit.Location = new System.Drawing.Point(12, 649);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 48);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "QUITTER";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblPswForg
            // 
            this.lblPswForg.AutoSize = true;
            this.lblPswForg.ForeColor = System.Drawing.Color.Blue;
            this.lblPswForg.Location = new System.Drawing.Point(350, 342);
            this.lblPswForg.Name = "lblPswForg";
            this.lblPswForg.Size = new System.Drawing.Size(111, 13);
            this.lblPswForg.TabIndex = 6;
            this.lblPswForg.Text = "Mot de passe oublié ?";
            this.lblPswForg.Click += new System.EventHandler(this.lblPswForg_Click);
            // 
            // FrmCnx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 709);
            this.Controls.Add(this.lblPswForg);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtBxMdp);
            this.Controls.Add(this.txtBxLog);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCnx";
            this.Text = "Connection / Création de compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBxLog;
        private System.Windows.Forms.TextBox txtBxMdp;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblPswForg;
    }
}

