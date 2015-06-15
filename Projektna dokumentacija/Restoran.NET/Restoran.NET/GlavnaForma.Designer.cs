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
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.racuniToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
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
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajArtiklToolStripMenuItem,
            this.pregledArtikalaToolStripMenuItem});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Visible = false;
            // 
            // dodajArtiklToolStripMenuItem
            // 
            this.dodajArtiklToolStripMenuItem.Name = "dodajArtiklToolStripMenuItem";
            this.dodajArtiklToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajArtiklToolStripMenuItem.Text = "Dodaj artikl";
            // 
            // pregledArtikalaToolStripMenuItem
            // 
            this.pregledArtikalaToolStripMenuItem.Name = "pregledArtikalaToolStripMenuItem";
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled artikala";
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeRačunaToolStripMenuItem,
            this.pregledRačunaToolStripMenuItem});
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.racuniToolStripMenuItem.Text = "Računi";
            this.racuniToolStripMenuItem.Visible = false;
            // 
            // kreiranjeRačunaToolStripMenuItem
            // 
            this.kreiranjeRačunaToolStripMenuItem.Name = "kreiranjeRačunaToolStripMenuItem";
            this.kreiranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kreiranjeRačunaToolStripMenuItem.Text = "Kreiranje računa";
            // 
            // pregledRačunaToolStripMenuItem
            // 
            this.pregledRačunaToolStripMenuItem.Name = "pregledRačunaToolStripMenuItem";
            this.pregledRačunaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pregledRačunaToolStripMenuItem.Text = "Pregled računa";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Visible = false;
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Visible = false;
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Visible = false;
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem dodajArtiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRačunaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
    }
}

