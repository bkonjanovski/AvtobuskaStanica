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
    public partial class DodadiPrevoznik_Admin : Form
    {
        public  Prevoznik prevoznik;
        public DodadiPrevoznik_Admin()
        {
            InitializeComponent();
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPrevoznik_Click(object sender, EventArgs e)
        {
            this.prevoznik= new Prevoznik(txtImePrevoznik.Text, txtLogoUrl.Text, txtWebStrana.Text, new List<Linija>());
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtLogoUrl_Enter(object sender, EventArgs e)
        {
            OpenFileDialog logo = new OpenFileDialog();
            logo.Filter = "Слики (*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)|*.BMP; *.JPG; *.GIF; *.PNG; *.TIFF";
            logo.Title = "Одбери слика од лого";

            if (logo.ShowDialog() == DialogResult.OK) { 
                txtLogoUrl.Text = logo.FileName;
            }
        }

        private void txtImePrevoznik_Validating(object sender, CancelEventArgs e)
        {
            if (txtImePrevoznik.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtImePrevoznik, "Внеси име на превозник");
            }
            else
                errorProvider1.SetError(txtImePrevoznik, "");
        }

        private void txtLogoUrl_Validating(object sender, CancelEventArgs e)
        {
            if (txtLogoUrl.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLogoUrl, "Внеси патека до лого");
            }
            else
                errorProvider1.SetError(txtLogoUrl, "");
        }
    }
}
