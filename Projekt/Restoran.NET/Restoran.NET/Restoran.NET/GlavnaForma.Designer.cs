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
            this.kreiranjeRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGlavniDioRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStavkeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kreiranjeRacunaToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajArtiklToolStripMenuItem,
            this.pregledArtikalaToolStripMenuItem});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Visible = false;
            // 
            // dodajArtiklToolStripMenuItem
            // 
            this.dodajArtiklToolStripMenuItem.Name = "dodajArtiklToolStripMenuItem";
            this.dodajArtiklToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.dodajArtiklToolStripMenuItem.Text = "Dodaj artikl";
            this.dodajArtiklToolStripMenuItem.Click += new System.EventHandler(this.dodajArtiklToolStripMenuItem_Click);
            // 
            // pregledArtikalaToolStripMenuItem
            // 
            this.pregledArtikalaToolStripMenuItem.Name = "pregledArtikalaToolStripMenuItem";
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled artikala";
            this.pregledArtikalaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtikalaToolStripMenuItem_Click);
            // 
            // kreiranjeRacunaToolStripMenuItem
            // 
            this.kreiranjeRacunaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeRačunaToolStripMenuItem,
            this.pregledRačunaToolStripMenuItem});
            this.kreiranjeRacunaToolStripMenuItem.Name = "kreiranjeRacunaToolStripMenuItem";
            this.kreiranjeRacunaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.kreiranjeRacunaToolStripMenuItem.Text = "Računi";
            this.kreiranjeRacunaToolStripMenuItem.Visible = false;
            // 
            // kreiranjeRačunaToolStripMenuItem
            // 
            this.kreiranjeRačunaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGlavniDioRačunaToolStripMenuItem,
            this.dodajStavkeRačunaToolStripMenuItem});
            this.kreiranjeRačunaToolStripMenuItem.Name = "kreiranjeRačunaToolStripMenuItem";
            this.kreiranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.kreiranjeRačunaToolStripMenuItem.Text = "Kreiranje računa";
            // 
            // dodajGlavniDioRačunaToolStripMenuItem
            // 
            this.dodajGlavniDioRačunaToolStripMenuItem.Name = "dodajGlavniDioRačunaToolStripMenuItem";
            this.dodajGlavniDioRačunaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.dodajGlavniDioRačunaToolStripMenuItem.Text = "Dodaj glavni dio računa";
            this.dodajGlavniDioRačunaToolStripMenuItem.Click += new System.EventHandler(this.dodajGlavniDioRačunaToolStripMenuItem_Click);
            // 
            // dodajStavkeRačunaToolStripMenuItem
            // 
            this.dodajStavkeRačunaToolStripMenuItem.Name = "dodajStavkeRačunaToolStripMenuItem";
            this.dodajStavkeRačunaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.dodajStavkeRačunaToolStripMenuItem.Text = "Dodaj stavke računa";
            this.dodajStavkeRačunaToolStripMenuItem.Click += new System.EventHandler(this.dodajStavkeRačunaToolStripMenuItem_Click);
            // 
            // pregledRačunaToolStripMenuItem
            // 
            this.pregledRačunaToolStripMenuItem.Name = "pregledRačunaToolStripMenuItem";
            this.pregledRačunaToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.pregledRačunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledRačunaToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Visible = false;
            this.narudžbeToolStripMenuItem.Click += new System.EventHandler(this.narudžbeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Visible = false;
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 479);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlavnaForma";
            this.ShowIcon = false;
            this.Text = "Restoran.NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem dodajGlavniDioRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStavkeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRačunaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kreiranjeRacunaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
    }
}

