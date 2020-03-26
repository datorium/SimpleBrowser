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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Super Datorium Browser. Version 0.1");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonForward_Click(sender, e);
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonGo_Click(sender, e);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Browser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F)
            {
                this.Close();
            }
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.F)
            {
                this.Close();
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkColor = Color.Black;
            Color lightColor = Color.White;

            foreach(Control item in this.Controls)
            {
                item.BackColor = darkColor;
                item.ForeColor = lightColor;
            }
            this.BackColor = darkColor;
            this.ForeColor = lightColor;
        }
    }
}
