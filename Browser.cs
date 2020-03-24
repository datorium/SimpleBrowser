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
            webBrowser1.Height = this.ClientRectangle.Height - 80;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Very cool browser");
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkColor = Color.FromArgb(50, 50, 50);
            Color lightColor = Color.White;
            this.BackColor = darkColor;
            foreach(Control item in this.Controls)
            {
                item.BackColor = darkColor;
                item.ForeColor = lightColor;
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkColor = Color.FromArgb(50, 50, 50);
            Color lightColor = Color.White;
            this.BackColor = lightColor;
            foreach (Control item in this.Controls)
            {
                item.BackColor = lightColor;
                item.ForeColor = darkColor;
            }
        }
    }
}
