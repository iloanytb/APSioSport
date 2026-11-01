namespace AppliConnexionForm
{
    partial class FrmPswForg
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
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtBxPsw = new System.Windows.Forms.TextBox();
            this.txtBxLog = new System.Windows.Forms.TextBox();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConf = new System.Windows.Forms.Label();
            this.txtBxConf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPsw
            // 
            this.lblPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPsw.Location = new System.Drawing.Point(279, 166);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(390, 41);
            this.lblPsw.TabIndex = 15;
            this.lblPsw.Text = "Insérez votre nouveau mot de passe :";
            this.lblPsw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLog.Location = new System.Drawing.Point(277, 52);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(356, 41);
            this.lblLog.TabIndex = 14;
            this.lblLog.Text = "Insérez votre login :";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxPsw
            // 
            this.txtBxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxPsw.Location = new System.Drawing.Point(282, 213);
            this.txtBxPsw.MaxLength = 50;
            this.txtBxPsw.Name = "txtBxPsw";
            this.txtBxPsw.PasswordChar = '*';
            this.txtBxPsw.Size = new System.Drawing.Size(516, 44);
            this.txtBxPsw.TabIndex = 13;
            // 
            // txtBxLog
            // 
            this.txtBxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxLog.Location = new System.Drawing.Point(282, 99);
            this.txtBxLog.MaxLength = 15;
            this.txtBxLog.Name = "txtBxLog";
            this.txtBxLog.Size = new System.Drawing.Size(516, 44);
            this.txtBxLog.TabIndex = 12;
            // 
            // btnVal
            // 
            this.btnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnVal.Location = new System.Drawing.Point(544, 413);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(256, 84);
            this.btnVal.TabIndex = 17;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancel.Location = new System.Drawing.Point(282, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(256, 84);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuler (QUITTER)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConf
            // 
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblConf.Location = new System.Drawing.Point(279, 290);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(422, 41);
            this.lblConf.TabIndex = 19;
            this.lblConf.Text = "Confirmez votre nouveau mot de passe :";
            this.lblConf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxConf
            // 
            this.txtBxConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtBxConf.Location = new System.Drawing.Point(282, 337);
            this.txtBxConf.MaxLength = 50;
            this.txtBxConf.Name = "txtBxConf";
            this.txtBxConf.PasswordChar = '*';
            this.txtBxConf.Size = new System.Drawing.Size(516, 44);
            this.txtBxConf.TabIndex = 18;
            // 
            // FrmPswForg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 639);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.txtBxConf);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtBxPsw);
            this.Controls.Add(this.txtBxLog);
            this.Name = "FrmPswForg";
            this.Text = "Mot de passe oublié";
            this.Load += new System.EventHandler(this.FrmPswForg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtBxPsw;
        private System.Windows.Forms.TextBox txtBxLog;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.TextBox txtBxConf;
    }
}