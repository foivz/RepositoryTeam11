using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.NET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Korisnicko_ime.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Korisnicko_ime.Text == ("kuhar") && Lozinka.Text == ("kuhar") || Korisnicko_ime.Text == ("zaposlenik") && Lozinka.Text == ("zaposlenik"))
            {
                GlavnaForma Glavna = new GlavnaForma();
                Glavna.Show();
                
            }

            else
            {
                MessageBox.Show("Unijeli ste pogresne podatke, pokusajte ponovo!");
                Korisnicko_ime.Text = " ";
                Lozinka.Text = " ";
            }
        }
    }
}
