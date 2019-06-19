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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AvtobuskaStanica
{
    public partial class AvtobuskaStanica_User : Form
    {
        public int zaPlakjanje = 0;
        public int vkupnoBileti = 0;
        public static Linija tekovna = null;
        public static Prevoznik tekoven = null;
        public AvtobuskaStanica_User()
        {
            InitializeComponent();
        }

        private void AvtobuskaStanica_User_Load(object sender, EventArgs e)
        {

            PrevozniciRefresh();
        }

        private void lstPrevoznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            LiniiRefresh();
        }

        private void lstLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            tekovna = lstLinii.SelectedItem as Linija;
            if (tekovna != null)
                btnKupi.Enabled = true;
        }
        public void LiniiRefresh()
        {
            lstLinii.Items.Clear();
            tekoven = lstPrevoznici.SelectedItem as Prevoznik;
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

        private void btnKupi_Click(object sender, EventArgs e)
        {
            KupiBilet_User forma = new KupiBilet_User();
            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (Prevoznik p in LogIn.Prevoznici)
                {
                    if (p == tekoven)

                        foreach (Linija l in p.Linii)
                            if (l == tekovna)
                                l.SlobodniMesta = KupiBilet_User.slobodniMesta;
                }

                LiniiRefresh();
                zaPlakjanje += KupiBilet_User.vkupnaCena;
                zaPlakjanje = (int)(zaPlakjanje - (zaPlakjanje * 0.2));
                vkupnoBileti += KupiBilet_User.brBileti;
                txtVkupnoBileti.Text = vkupnoBileti.ToString();
                Karta karta = new Karta(tekoven.ToString(), tekovna.ToString(), KupiBilet_User.brBileti, KupiBilet_User.Chekirana, KupiBilet_User.Povratna, KupiBilet_User.Studentska);
                lstMojBileti.Items.Add(karta);
                txtVkupnoCena.Text = zaPlakjanje.ToString() + " ден.";

                LogIn.objekt = new Ser(LogIn.Prevoznici);
                System.Runtime.Serialization.IFormatter fmt = new
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream("avtobuska.db", FileMode.Create,
                FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, LogIn.objekt);
                strm.Close();
            }

            
        }

        private void AvtobuskaStanica_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstMojBileti.Items.RemoveAt(lstMojBileti.SelectedIndex);
        }

        private void lstMojBileti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrishi.Enabled = true;
        }
    }
}
