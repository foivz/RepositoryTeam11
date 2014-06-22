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
    public partial class frmDodavanjeArtikla : Form
    {
        public frmDodavanjeArtikla()
        {
            InitializeComponent();
        }

        private void artiklBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artiklBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void frmDodavanjeArtikla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Jedinica_mjere' table. You can move, or remove it, as needed.
            this.jedinica_mjereTableAdapter.Fill(this.restoranDBDataSet.Jedinica_mjere);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);
            artiklBindingSource.AddNew();
        }

         
        private void btnOdbaci_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            
            try
            {
                dodajNoviArtikl();
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom unosa podataka, pokušajte ponovno", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmArtikli pregledArtikala = new frmArtikli();
            pregledArtikala.MdiParent = (GlavnaForma)this.ParentForm;
            pregledArtikala.Show();

        }

        private void dodajNoviArtikl()
        {
            this.Validate();
            this.artiklBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);
        }
      

        




    }
}
