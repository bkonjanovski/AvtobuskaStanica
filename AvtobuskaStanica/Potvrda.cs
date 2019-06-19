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
    public partial class Potvrda : Form
    {
        public Potvrda()
        {
            InitializeComponent();
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
