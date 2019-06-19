using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtobuskaStanica
{
    public partial class KupiBilet_Guest : Form
    {
        public int brKarti;
        public static int vkupnaCena;
        public static int slobodniMesta;
        public static int brBileti;
        public KupiBilet_Guest()
        {
            InitializeComponent();
            if (File.Exists(AvtobuskaStanica_Guest.tekoven.LogoUrl))
                pctPrevoznikLogo.Image = Image.FromFile(AvtobuskaStanica_Guest.tekoven.LogoUrl); //AvtobuskaStanica_Guest.tekoven.LogoUrl;
            pctMapa.Image = Image.FromFile(AvtobuskaStanica_Guest.tekovna.MapaUrl);
            txtPocetna.Text = AvtobuskaStanica_Guest.tekovna.PocetnaDestinacija;
            txtKrajna.Text = AvtobuskaStanica_Guest.tekovna.KrajnaDestinacija;
            slobodniMesta = AvtobuskaStanica_Guest.tekovna.SlobodniMesta;
            txtSlobodni.Text = slobodniMesta.ToString();
            vkupnaCena = AvtobuskaStanica_Guest.tekovna.Cena;
            txtVkupnoCena.Text= vkupnaCena.ToString()+" ден.";
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KupiBilet_Guest_Load(object sender, EventArgs e)
        {
           
        }
        
        public void btnKupi_Click(object sender, EventArgs e)
        {
            brKarti = (int)numBrKarti.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void numBrKarti_ValueChanged(object sender, EventArgs e)
        {
            if(slobodniMesta <= 0)
            {
                MessageBox.Show("Нема повеќе слободни седишта!");
                //numBrKarti.Value -= 1;
            } else { 
            vkupnaCena = AvtobuskaStanica_Guest.tekovna.Cena * (int)numBrKarti.Value;
            slobodniMesta = AvtobuskaStanica_Guest.tekovna.SlobodniMesta - (int)numBrKarti.Value;
            txtSlobodni.Text = slobodniMesta.ToString();
            txtVkupnoCena.Text = vkupnaCena.ToString()+(" ден.");
                brBileti = (int)numBrKarti.Value;
            }
        }

        private void chkStudentska_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStudentska.Checked)
                vkupnaCena -= 50;
            else
                vkupnaCena += 50;

            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }

        private void chkPovraten_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPovraten.Checked)
                vkupnaCena += 150;
            else
                vkupnaCena -= 150;

            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }

        private void chkChekirana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChekirana.Checked)
                vkupnaCena += 30;
            else
                vkupnaCena -= 30;

            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }
    }
}
