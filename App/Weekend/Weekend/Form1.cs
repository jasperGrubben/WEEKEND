using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistatie_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBevestigLogin_Click(object sender, EventArgs e)
        {
            //tests
            string wachtwoord = "BINGCHILLING";
            string gebruikers = "BINGCHILLING";
            string UserLogin = txtGebruikernaamInput.Text;
            string WachLogin = txtWachtwoordLogin.Text;
            if (WachLogin == wachtwoord && UserLogin == gebruikers)
            {
                MessageBox.Show("Login gelukt");
                lblErrorLogin.Text = "blayt";
            }
        }
    }
}
