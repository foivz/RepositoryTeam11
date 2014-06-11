namespace Restoran.NET
{
    partial class GlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odabirPićaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odabirJelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.jeloToolStripMenuItem,
            this.jeloToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // jeloToolStripMenuItem
            // 
            this.jeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odabirPićaToolStripMenuItem});
            this.jeloToolStripMenuItem.Name = "jeloToolStripMenuItem";
            this.jeloToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.jeloToolStripMenuItem.Text = "Pice";
            // 
            // odabirPićaToolStripMenuItem
            // 
            this.odabirPićaToolStripMenuItem.Name = "odabirPićaToolStripMenuItem";
            this.odabirPićaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odabirPićaToolStripMenuItem.Text = "Odabir pica";
            this.odabirPićaToolStripMenuItem.Click += new System.EventHandler(this.odabirPićaToolStripMenuItem_Click);
            // 
            // jeloToolStripMenuItem1
            // 
            this.jeloToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odabirJelaToolStripMenuItem});
            this.jeloToolStripMenuItem1.Name = "jeloToolStripMenuItem1";
            this.jeloToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.jeloToolStripMenuItem1.Text = "Jelo";
            // 
            // odabirJelaToolStripMenuItem
            // 
            this.odabirJelaToolStripMenuItem.Name = "odabirJelaToolStripMenuItem";
            this.odabirJelaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odabirJelaToolStripMenuItem.Text = "Odabir jela";
            this.odabirJelaToolStripMenuItem.Click += new System.EventHandler(this.odabirJelaToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 389);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "Restoran.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odabirPićaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odabirJelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

