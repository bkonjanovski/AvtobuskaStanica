using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtobuskaStanica
{
    public partial class KupiBilet_User : Form
    {

        public int brKarti;
        public static int vkupnaCena;
        public static int slobodniMesta;
        public static int brBileti;
        public static bool Chekirana = false;
        public static bool Povratna = false;
        public static bool Studentska = false;

        public KupiBilet_User()
        {
            InitializeComponent();
            pctPrevoznikLogo.Image = Image.FromFile(AvtobuskaStanica_User.tekoven.LogoUrl); //AvtobuskaStanica_Guest.tekoven.LogoUrl;
            pctMapa.Image = Image.FromFile(AvtobuskaStanica_User.tekovna.MapaUrl);
            txtPocetna.Text = AvtobuskaStanica_User.tekovna.PocetnaDestinacija;
            txtKrajna.Text = AvtobuskaStanica_User.tekovna.KrajnaDestinacija;
            slobodniMesta = AvtobuskaStanica_User.tekovna.SlobodniMesta;
            txtSlobodni.Text = slobodniMesta.ToString();
            vkupnaCena = AvtobuskaStanica_User.tekovna.Cena;
            txtVkupnoCena.Text = vkupnaCena.ToString() + " ден.";
        }

        private void KupiBilet_User_Load(object sender, EventArgs e)
        {

        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void btnKupi_Click(object sender, EventArgs e)
        {
            brKarti = (int)numBrKarti.Value;
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void numBrKarti_ValueChanged(object sender, EventArgs e)
        {
            if (slobodniMesta <= 0)
            {
                MessageBox.Show("Нема повеќе слободни седишта!");
                //numBrKarti.Value -= 1;
            }
            else
            {
                vkupnaCena = AvtobuskaStanica_User.tekovna.Cena * (int)numBrKarti.Value;
                slobodniMesta = AvtobuskaStanica_User.tekovna.SlobodniMesta - (int)numBrKarti.Value;
                txtSlobodni.Text = slobodniMesta.ToString();
                txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
                brBileti = (int)numBrKarti.Value;
            }
        }

        private void chkStudentska_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStudentska.Checked) { 
                vkupnaCena -= 50;
                Studentska = true;
            }
            else { 
                vkupnaCena += 50;
            }
            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }

        private void chkPovraten_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPovraten.Checked)
            {
                vkupnaCena += 150;
                Povratna = true;
            }
            else
            {
                vkupnaCena -= 150;

            }
                

            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }

        private void chkChekirana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChekirana.Checked)
            {
                vkupnaCena += 30;
                Chekirana = true;
            }
                
            else
            {
                vkupnaCena -= 30;
            }
                

            txtVkupnoCena.Text = vkupnaCena.ToString() + (" ден.");
        }

       
    }
}
