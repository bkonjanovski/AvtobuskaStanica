using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AvtobuskaStanica
{
    public partial class DodadiLinija : Form
    {
        public Linija linija;
        public DodadiLinija()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            linija = new Linija(txtPocetna.Text, txtKrajna.Text, Convert.ToInt32(txtCena.Text), Convert.ToInt32(txtSlobodni.Text), txtMapa.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMapa_Enter(object sender, EventArgs e)
        {
            OpenFileDialog mapa = new OpenFileDialog();
            mapa.Filter = "Слики (*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)|*.BMP; *.JPG; *.GIF; *.PNG; *.TIFF";
            mapa.Title = "Одбери слика од мапа";

            if (mapa.ShowDialog() == DialogResult.OK) { 
                txtMapa.Text = mapa.FileName;
            }
        }

        private void txtPocetna_Validating(object sender, CancelEventArgs e)
        {
            if (txtPocetna.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPocetna, "Внеси Почетна Дестинација");
            }
            else
                errorProvider1.SetError(txtPocetna, "");
        }

        private void txtKrajna_Validating(object sender, CancelEventArgs e)
        {
            if (txtKrajna.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtKrajna, "Внеси Крајна Дестинација");
            }
            else
                errorProvider1.SetError(txtKrajna, "");
        }

        private void txtMapa_Validating(object sender, CancelEventArgs e)
        {
            if (txtMapa.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMapa, "Внеси локација на мапа");
            }
            else
                errorProvider1.SetError(txtMapa, "");
        }
    }
}
