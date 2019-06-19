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
    }
}
