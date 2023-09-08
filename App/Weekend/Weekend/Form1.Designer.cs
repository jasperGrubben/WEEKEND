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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.btnBevestigLogin = new System.Windows.Forms.Button();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblGebruikers = new System.Windows.Forms.Label();
            this.txtWachtwoordLogin = new System.Windows.Forms.TextBox();
            this.txtGebruikernaamInput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistatie = new System.Windows.Forms.Button();
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
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1464, 606);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblErrorLogin);
            this.pnlLogin.Controls.Add(this.btnBevestigLogin);
            this.pnlLogin.Controls.Add(this.lblWachtwoord);
            this.pnlLogin.Controls.Add(this.lblGebruikers);
            this.pnlLogin.Controls.Add(this.txtWachtwoordLogin);
            this.pnlLogin.Controls.Add(this.txtGebruikernaamInput);
            this.pnlLogin.Location = new System.Drawing.Point(388, 13);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(674, 571);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Visible = false;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorLogin.Location = new System.Drawing.Point(276, 329);
            this.lblErrorLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(0, 25);
            this.lblErrorLogin.TabIndex = 5;
            // 
            // btnBevestigLogin
            // 
            this.btnBevestigLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBevestigLogin.Location = new System.Drawing.Point(184, 256);
            this.btnBevestigLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBevestigLogin.Name = "btnBevestigLogin";
            this.btnBevestigLogin.Size = new System.Drawing.Size(248, 50);
            this.btnBevestigLogin.TabIndex = 4;
            this.btnBevestigLogin.Text = "Bevestig";
            this.btnBevestigLogin.UseVisualStyleBackColor = true;
            this.btnBevestigLogin.Click += new System.EventHandler(this.btnBevestigLogin_Click);
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWachtwoord.Location = new System.Drawing.Point(140, 177);
            this.lblWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(137, 25);
            this.lblWachtwoord.TabIndex = 3;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // lblGebruikers
            // 
            this.lblGebruikers.AutoSize = true;
            this.lblGebruikers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGebruikers.Location = new System.Drawing.Point(116, 115);
            this.lblGebruikers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruikers.Name = "lblGebruikers";
            this.lblGebruikers.Size = new System.Drawing.Size(165, 25);
            this.lblGebruikers.TabIndex = 2;
            this.lblGebruikers.Text = "Gebruikernaam:";
            // 
            // txtWachtwoordLogin
            // 
            this.txtWachtwoordLogin.Location = new System.Drawing.Point(282, 177);
            this.txtWachtwoordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWachtwoordLogin.Name = "txtWachtwoordLogin";
            this.txtWachtwoordLogin.Size = new System.Drawing.Size(216, 31);
            this.txtWachtwoordLogin.TabIndex = 1;
            // 
            // txtGebruikernaamInput
            // 
            this.txtGebruikernaamInput.Location = new System.Drawing.Point(282, 110);
            this.txtGebruikernaamInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGebruikernaamInput.Name = "txtGebruikernaamInput";
            this.txtGebruikernaamInput.Size = new System.Drawing.Size(216, 31);
            this.txtGebruikernaamInput.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(248, 206);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 150);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistatie
            // 
            this.btnRegistatie.Location = new System.Drawing.Point(948, 206);
            this.btnRegistatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistatie.Name = "btnRegistatie";
            this.btnRegistatie.Size = new System.Drawing.Size(240, 150);
            this.btnRegistatie.TabIndex = 0;
            this.btnRegistatie.Text = "Registeren";
            this.btnRegistatie.UseVisualStyleBackColor = true;
            this.btnRegistatie.Click += new System.EventHandler(this.btnRegistatie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1800, 892);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rekensysteem";
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

