﻿namespace Weekend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGebruikers = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGebruikers);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(387, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 572);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 31);
            this.textBox2.TabIndex = 1;
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

