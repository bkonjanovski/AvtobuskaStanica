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
    public partial class AvtobuskaStanica_Admin : Form
    {
        int vkupnoLinii;
        public AvtobuskaStanica_Admin()
        {
            InitializeComponent();
        }

        private void AvtobuskaStanica_Admin_Load(object sender, EventArgs e)
        {
            PrevozniciRefresh();
            VkupnoRefresh();
        }

        private void lstPrevoznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            LiniiRefresh();
            VkupnoRefresh();
            btnAddLinija.Enabled = true;
            btnRmovePrevoznik.Enabled = true;
            
            btnAddLinija.Enabled = true;
        }

        public void LiniiRefresh()
        {
            lstLinii.Items.Clear();
            Prevoznik tekoven = lstPrevoznici.SelectedItem as Prevoznik;
            if (tekoven != null)
                foreach (Linija linija in tekoven.Linii)
                {
                    lstLinii.Items.Add(linija);
                }

            VkupnoRefresh();
        }

        public void PrevozniciRefresh()
        {
            lstLinii.Items.Clear();
            foreach (Prevoznik prevoznik in LogIn.Prevoznici)
            {
                lstPrevoznici.Items.Add(prevoznik);
            }
        }

        public void VkupnoRefresh()
        {
            txtVkupnoPrevoznici.Text = lstPrevoznici.Items.Count.ToString();
            vkupnoLinii = 0;
            foreach (Prevoznik p in lstPrevoznici.Items)
                foreach (Linija l in p.Linii)
                    vkupnoLinii++;
            txtVkupnoLinii.Text = vkupnoLinii.ToString();
        }

        private void btnAddPrevoznik_Click(object sender, EventArgs e)
        {
            DodadiPrevoznik_Admin dodadi = new DodadiPrevoznik_Admin();
            if(dodadi.ShowDialog()==DialogResult.OK)
            {
                Prevoznik a = dodadi.prevoznik;
                LogIn.Prevoznici.Add(a);
                lstPrevoznici.Items.Clear();
                PrevozniciRefresh();
            }
            LogIn.objekt = new Ser(LogIn.Prevoznici);
            System.Runtime.Serialization.IFormatter fmt = new
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, LogIn.objekt);
            strm.Close();

            VkupnoRefresh();

        }

        private void btnRmovePrevoznik_Click(object sender, EventArgs e)
        {
            Potvrda potvrda = new Potvrda();
            if (potvrda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                LogIn.Prevoznici.Remove(lstPrevoznici.SelectedItem as Prevoznik);
            lstPrevoznici.Items.Clear();
            PrevozniciRefresh();

            LogIn.objekt = new Ser(LogIn.Prevoznici);
            System.Runtime.Serialization.IFormatter fmt = new
System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, LogIn.objekt);
            strm.Close();
            }

            VkupnoRefresh();
        }

        private void btnAddLinija_Click(object sender, EventArgs e)
        {
            DodadiLinija dodadi = new DodadiLinija();
            if(dodadi.ShowDialog()==DialogResult.OK)
            {
                Prevoznik s = lstPrevoznici.SelectedItem as Prevoznik;
                s.Linii.Add(dodadi.linija as Linija);
                lstLinii.Items.Clear();
                LiniiRefresh();
            }


            LogIn.objekt = new Ser(LogIn.Prevoznici);
            System.Runtime.Serialization.IFormatter fmt = new
System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, LogIn.objekt);
            strm.Close();

            VkupnoRefresh();
        }

        private void btnRemoveLinija_Click(object sender, EventArgs e)
        {
            Potvrda potvrda = new Potvrda();
            if (potvrda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                Prevoznik s = lstPrevoznici.SelectedItem as Prevoznik;
            s.Linii.Remove(lstLinii.SelectedItem as Linija);
            LiniiRefresh();
            

            LogIn.objekt = new Ser(LogIn.Prevoznici);
            System.Runtime.Serialization.IFormatter fmt = new
System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, LogIn.objekt);
            strm.Close();
         }

            VkupnoRefresh();
        }
        private void AvtobuskaStanica_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lstLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveLinija.Enabled = true;
        }
    }
}
