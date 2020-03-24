namespace SimpleBrowser
{
    partial class Browser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonHome = new System.Windows.Forms.Button();
            this.AddressBar = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(611, 442);
            this.webBrowser1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(14, 43);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(109, 43);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBar.Location = new System.Drawing.Point(129, 43);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(251, 38);
            this.AddressBar.TabIndex = 2;
            this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBar_KeyDown);
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(386, 43);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(69, 43);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "✓";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(461, 43);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(58, 43);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "↺";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Location = new System.Drawing.Point(525, 43);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(57, 43);
            this.buttonForward.TabIndex = 5;
            this.buttonForward.Text = "↻";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darkModeToolStripMenuItem.Text = "Dark mode";
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightModeToolStripMenuItem.Text = "Light mode";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 542);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Browser";
            this.Text = "Datorium Simple Browser";
            this.Resize += new System.EventHandler(this.Browser_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TextBox AddressBar;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
    }
}

