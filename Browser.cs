using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            InitializeBrowser();
        }
        private void InitializeBrowser()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Width = this.ClientRectangle.Width;
            webBrowser1.Height = this.ClientRectangle.Height - 50;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBar.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(AddressBar.Text);
            }
        }

        private void Browser_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = this.ClientRectangle.Width;
            webBrowser1.Height = this.ClientRectangle.Height - 50;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50,50,50);
            foreach(Control contr in this.Controls)
            {
                contr.BackColor = Color.FromArgb(50, 50, 50);
                contr.ForeColor = Color.White;
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
            foreach (Control contr in this.Controls)
            {
                contr.BackColor = Color.FromArgb(200, 200, 200);
                contr.ForeColor = Color.Black;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
