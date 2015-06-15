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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
