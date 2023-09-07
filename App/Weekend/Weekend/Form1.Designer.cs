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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGebruikers = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistatie = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.btnRegistatie);
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlMain.Location = new System.Drawing.Point(115, 53);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(976, 387);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGebruikers);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(258, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 366);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // lblGebruikers
            // 
            this.lblGebruikers.AutoSize = true;
            this.lblGebruikers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGebruikers.Location = new System.Drawing.Point(78, 74);
            this.lblGebruikers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGebruikers.Name = "lblGebruikers";
            this.lblGebruikers.Size = new System.Drawing.Size(103, 16);
            this.lblGebruikers.TabIndex = 2;
            this.lblGebruikers.Text = "Gebruikernaam:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 113);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 131);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 96);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistatie
            // 
            this.btnRegistatie.Location = new System.Drawing.Point(633, 131);
            this.btnRegistatie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistatie.Name = "btnRegistatie";
            this.btnRegistatie.Size = new System.Drawing.Size(160, 96);
            this.btnRegistatie.TabIndex = 0;
            this.btnRegistatie.Text = "Registeren";
            this.btnRegistatie.UseVisualStyleBackColor = true;
            this.btnRegistatie.Click += new System.EventHandler(this.btnRegistatie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1227, 506);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGebruikers;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

