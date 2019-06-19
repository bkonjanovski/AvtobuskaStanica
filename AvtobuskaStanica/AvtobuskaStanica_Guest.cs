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
    public partial class AvtobuskaStanica_Guest : Form
    {
        public int zaPlakjanje = 0;
        public int vkupnoBileti = 0;
        public static Linija tekovna = null;
        public static Prevoznik tekoven = null;
        public AvtobuskaStanica_Guest()
        {
            InitializeComponent();
        }

        private void btnKupiGuest_Click(object sender, EventArgs e)
        {
            KupiBilet_Guest forma = new KupiBilet_Guest();
            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(Prevoznik p in LogIn.Prevoznici)
                {
                    if(p==tekoven)

                        foreach(Linija l in p.Linii)
                            if(l==tekovna)
                            l.SlobodniMesta = KupiBilet_Guest.slobodniMesta;     
                }

                LiniiRefresh();
                zaPlakjanje += KupiBilet_Guest.vkupnaCena;
                vkupnoBileti += KupiBilet_Guest.brBileti;
                txtVkupnoBileti.Text = vkupnoBileti.ToString();
                txtVkupnoCena.Text = zaPlakjanje.ToString() + " ден.";
            }

            LogIn.objekt = new Ser(LogIn.Prevoznici);
            System.Runtime.Serialization.IFormatter fmt = new
System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
            FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, LogIn.objekt);
            strm.Close();
        }

        private void AvtobuskaStanica_Guest_Load(object sender, EventArgs e)
        {
            PrevozniciRefresh();
        }

        private void lstPrevoznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            tekoven = lstPrevoznici.SelectedItem as Prevoznik;
            LiniiRefresh();
            btnKupiGuest.Enabled = false;
        }

        private void lstLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            tekovna = lstLinii.SelectedItem as Linija;
            if (tekovna != null)
                btnKupiGuest.Enabled = true;
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
        }

        public void PrevozniciRefresh()
        {
            lstLinii.Items.Clear();
            foreach (Prevoznik prevoznik in LogIn.Prevoznici)
            {
                lstPrevoznici.Items.Add(prevoznik);
            }
        }

        private void AvtobuskaStanica_Guest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Potvrda potvrda = new Potvrda();
            if (potvrda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }
    }
}
