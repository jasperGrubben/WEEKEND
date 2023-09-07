namespace Weekend
{
    partial class Form1
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
            this.ietsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRegistatie = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtGebruikernaamInput = new System.Windows.Forms.TextBox();
            this.txtWachtwoordLogin = new System.Windows.Forms.TextBox();
            this.lblGebruikers = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.btnBevestigLogin = new System.Windows.Forms.Button();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ietsToolStripMenuItem
            // 
            this.ietsToolStripMenuItem.Name = "ietsToolStripMenuItem";
            this.ietsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ietsToolStripMenuItem.Text = "iets";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.closeToolStripMenuItem.Text = "close";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(0, 0);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(75, 23);
            this.btnInloggen.TabIndex = 0;
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Location = new System.Drawing.Point(0, 0);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(75, 23);
            this.btnRegisteren.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Controls.Add(this.pnlLogin);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.btnRegistatie);
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlMain.Location = new System.Drawing.Point(172, 83);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1464, 605);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnRegistatie
            // 
            this.btnRegistatie.Location = new System.Drawing.Point(949, 205);
            this.btnRegistatie.Name = "btnRegistatie";
            this.btnRegistatie.Size = new System.Drawing.Size(240, 150);
            this.btnRegistatie.TabIndex = 0;
            this.btnRegistatie.Text = "Registeren";
            this.btnRegistatie.UseVisualStyleBackColor = true;
            this.btnRegistatie.Click += new System.EventHandler(this.btnRegistatie_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(247, 205);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 150);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblErrorLogin);
            this.pnlLogin.Controls.Add(this.btnBevestigLogin);
            this.pnlLogin.Controls.Add(this.lblWachtwoord);
            this.pnlLogin.Controls.Add(this.lblGebruikers);
            this.pnlLogin.Controls.Add(this.txtWachtwoordLogin);
            this.pnlLogin.Controls.Add(this.txtGebruikernaamInput);
            this.pnlLogin.Location = new System.Drawing.Point(387, 14);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(673, 572);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Visible = false;
            // 
            // txtGebruikernaamInput
            // 
            this.txtGebruikernaamInput.Location = new System.Drawing.Point(282, 110);
            this.txtGebruikernaamInput.Name = "txtGebruikernaamInput";
            this.txtGebruikernaamInput.Size = new System.Drawing.Size(217, 31);
            this.txtGebruikernaamInput.TabIndex = 0;
            // 
            // txtWachtwoordLogin
            // 
            this.txtWachtwoordLogin.Location = new System.Drawing.Point(282, 176);
            this.txtWachtwoordLogin.Name = "txtWachtwoordLogin";
            this.txtWachtwoordLogin.Size = new System.Drawing.Size(217, 31);
            this.txtWachtwoordLogin.TabIndex = 1;
            // 
            // lblGebruikers
            // 
            this.lblGebruikers.AutoSize = true;
            this.lblGebruikers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGebruikers.Location = new System.Drawing.Point(117, 116);
            this.lblGebruikers.Name = "lblGebruikers";
            this.lblGebruikers.Size = new System.Drawing.Size(165, 25);
            this.lblGebruikers.TabIndex = 2;
            this.lblGebruikers.Text = "Gebruikernaam:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWachtwoord.Location = new System.Drawing.Point(139, 176);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(137, 25);
            this.lblWachtwoord.TabIndex = 3;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // btnBevestigLogin
            // 
            this.btnBevestigLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBevestigLogin.Location = new System.Drawing.Point(185, 255);
            this.btnBevestigLogin.Name = "btnBevestigLogin";
            this.btnBevestigLogin.Size = new System.Drawing.Size(248, 50);
            this.btnBevestigLogin.TabIndex = 4;
            this.btnBevestigLogin.Text = "Bevestig";
            this.btnBevestigLogin.UseVisualStyleBackColor = true;
            this.btnBevestigLogin.Click += new System.EventHandler(this.btnBevestigLogin_Click);
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorLogin.Location = new System.Drawing.Point(277, 329);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(0, 25);
            this.lblErrorLogin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1840, 791);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ietsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Button btnRegisteren;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistatie;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblGebruikers;
        private System.Windows.Forms.TextBox txtWachtwoordLogin;
        private System.Windows.Forms.TextBox txtGebruikernaamInput;
        private System.Windows.Forms.Button btnBevestigLogin;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblErrorLogin;
    }
}

