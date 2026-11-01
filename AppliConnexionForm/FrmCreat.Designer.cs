namespace AppliConnexionForm
{
    partial class FrmCreat
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBxLog = new System.Windows.Forms.TextBox();
            this.txtBxPsw = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txtBxConfPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(312, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pour accéder à ce contenu, veuillez créer un compte :";
            // 
            // txtBxLog
            // 
            this.txtBxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxLog.Location = new System.Drawing.Point(348, 114);
            this.txtBxLog.MaxLength = 15;
            this.txtBxLog.Name = "txtBxLog";
            this.txtBxLog.Size = new System.Drawing.Size(516, 44);
            this.txtBxLog.TabIndex = 4;
            // 
            // txtBxPsw
            // 
            this.txtBxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxPsw.Location = new System.Drawing.Point(348, 228);
            this.txtBxPsw.MaxLength = 50;
            this.txtBxPsw.Name = "txtBxPsw";
            this.txtBxPsw.PasswordChar = '*';
            this.txtBxPsw.Size = new System.Drawing.Size(516, 44);
            this.txtBxPsw.TabIndex = 5;
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLog.Location = new System.Drawing.Point(343, 67);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(356, 44);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Insérez votre login :";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPsw
            // 
            this.lblPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPsw.Location = new System.Drawing.Point(345, 181);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(356, 44);
            this.lblPsw.TabIndex = 11;
            this.lblPsw.Text = "Insérez votre mot de passe :";
            this.lblPsw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancel.Location = new System.Drawing.Point(348, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(256, 84);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Annuler (QUITTER)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVal
            // 
            this.btnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnVal.Location = new System.Drawing.Point(610, 551);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(256, 84);
            this.btnVal.TabIndex = 13;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // lblConfPass
            // 
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblConfPass.Location = new System.Drawing.Point(349, 298);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(356, 44);
            this.lblConfPass.TabIndex = 15;
            this.lblConfPass.Text = "Confirmez votre mot de passe :";
            this.lblConfPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxConfPass
            // 
            this.txtBxConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxConfPass.Location = new System.Drawing.Point(352, 345);
            this.txtBxConfPass.MaxLength = 50;
            this.txtBxConfPass.Name = "txtBxConfPass";
            this.txtBxConfPass.PasswordChar = '*';
            this.txtBxConfPass.Size = new System.Drawing.Size(516, 44);
            this.txtBxConfPass.TabIndex = 14;
            // 
            // FrmCreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 686);
            this.Controls.Add(this.lblConfPass);
            this.Controls.Add(this.txtBxConfPass);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtBxPsw);
            this.Controls.Add(this.txtBxLog);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCreat";
            this.Text = "Création Nouvel Utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBxLog;
        private System.Windows.Forms.TextBox txtBxPsw;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.TextBox txtBxConfPass;
    }
}