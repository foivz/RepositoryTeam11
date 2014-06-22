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
    public partial class PregledRacuna : Form
    {
        public PregledRacuna()
        {
            InitializeComponent();
        }

        private void PregledRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.restoranDBDataSet.Zaposlenik);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Stavka_racuna' table. You can move, or remove it, as needed.
            this.stavka_racunaTableAdapter.Fill(this.restoranDBDataSet.Stavka_racuna);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.restoranDBDataSet.Racun);

        }

        private void btnDodajGlavno_Click(object sender, EventArgs e)
        {
            GlavniDioRacuna glavniDio = new GlavniDioRacuna();
            glavniDio.MdiParent = (GlavnaForma)this.ParentForm;
            glavniDio.Show();

            this.Close();
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            StavkeRacuna stavkeRacuna = new StavkeRacuna();
            stavkeRacuna.MdiParent = (GlavnaForma)this.ParentForm;
            stavkeRacuna.Show();

            this.Close();
        }

        private void btnObrisiGlavniDio_Click(object sender, EventArgs e)
        {
            try
            {
                this.racunBindingSource.RemoveCurrent();
                this.racunTableAdapter.Update(restoranDBDataSet.Racun);
            }

            catch
            {
                MessageBox.Show("Pogreška prilikom brisanja, pokušajte ponovno", "Pogreška prilikom brisanja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnObrisiStavke_Click(object sender, EventArgs e)
        {
            try {
                this.stavkaRacunaBindingSource.RemoveCurrent();
                this.stavka_racunaTableAdapter.Update(restoranDBDataSet.Stavka_racuna);
            }

            catch
            {
                MessageBox.Show("Pogreška prilikom brisanja, pokušajte ponovno", "Pogreška prilikom brisanja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            try {
                this.stavkaRacunaBindingSource.EndEdit();
                this.stavka_racunaTableAdapter.Update(restoranDBDataSet.Stavka_racuna);


                this.racunBindingSource.EndEdit();
                this.racunTableAdapter.Update(restoranDBDataSet.Racun);
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom ažuriranja podataka, pokušajte ponovno", "Pogreška prilikom ažuriranja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
