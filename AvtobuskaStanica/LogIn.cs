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
using System.IO;

namespace AvtobuskaStanica
{
    [Serializable]
    public partial class LogIn : Form
    {
        public static List<Prevoznik> Prevoznici = new List<Prevoznik>();
        public static Ser objekt;


        public LogIn()
        {
            InitializeComponent();
            StartniVrednosti();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == "")
            {
               // e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Внеси username");
            }
            else
                errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
               // e.Cancel = true;
                errorProvider2.SetError(txtPassword, "Внеси password");
            }
            else
                errorProvider2.SetError(txtPassword, "");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin") {
                if (txtPassword.Text == "admin123")
                {
                    AvtobuskaStanica_Admin welcome = new AvtobuskaStanica_Admin();

                    this.Hide();
                    welcome.ShowDialog();
                }
                else
                    MessageBox.Show("Погрешна лозинка!");
            }

            else if (txtUsername.Text == "user1")
            {
                if (txtPassword.Text == "user123") {
                    AvtobuskaStanica_User welcome = new AvtobuskaStanica_User();
                    this.Hide();
                    welcome.ShowDialog();
                }
                else
                    MessageBox.Show("Погрешна лозинка!");
            }

            else
                MessageBox.Show("Погрешен username и/или password!");

        }

        private void lnkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AvtobuskaStanica_Guest welcome = new AvtobuskaStanica_Guest();
            this.Hide();
            welcome.ShowDialog();
    }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
            if (!File.Exists("avotbuska.db"))
            {
               
                System.Runtime.Serialization.IFormatter fmt = new
    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream("avtobuska.db", FileMode.Open,
                FileAccess.Read, FileShare.None);
                objekt = (Ser)fmt.Deserialize(strm);
                
                strm.Close();
                foreach (Prevoznik p in objekt.lista)
                    Prevoznici.Add(p);
            }
           
        }

        public void StartniVrednosti()
        {
            /*
            List<Linija> tmpLinii = new List<Linija>();
            tmpLinii.Add(new Linija("Ohrid", "Skopje", 450, 40, "img/Mapa_Ohrid-Skopje.jpg"));
            tmpLinii.Add(new Linija("Skopje", "Kavadarci", 270, 30, "img/Mapa_Skopje-Kavadarci.jpg"));
            tmpLinii.Add(new Linija("Ohrid", "Bitola", 270, 30, "img/Mapa_Ohrid-Bitola.jpg"));
            tmpLinii.Add(new Linija("Skopje", "Nish", 690, 40, "img/Mapa_Skopje-Nish.jpg"));
            Prevoznici.Add(new Prevoznik(
                "Galeb",
                "img/galeb_logo.jpg",
                "www.galeb.mk",
                tmpLinii
                ));

            tmpLinii = new List<Linija>();
            tmpLinii.Add(new Linija("Kicevo", "Skopje", 230, 30, "img/Mapa_Kicevo-Skopje.jpg"));
            tmpLinii.Add(new Linija("Bitola", "Kicevo", 400, 40, "img/Mapa_Bitola-Kicevo.jpg"));
            tmpLinii.Add(new Linija("Ohrid", "Skopje", 420, 40, "img/Mapa_Ohrid-Skopje.jpg"));
            Prevoznici.Add(new Prevoznik(
                "Delfina Turs",
                "img/delfina_logo.jpg",
                "www.delfinaturs.com.mk",
                tmpLinii
                ));

            tmpLinii = new List<Linija>();
            tmpLinii.Add(new Linija("Prilep", "Veles", 500, 40, "img/Mapa_Prilep-Veles.jpg"));
            Prevoznici.Add(new Prevoznik(
                "Transkop",
                "img/transkop_logo.jpg",
                "www.transkop.mk",
                tmpLinii
                ));

            tmpLinii = new List<Linija>();
            tmpLinii.Add(new Linija("Skopje", "Kumanovo", 100, 30, "img/Mapa_Skopje-Kumanovo.jpg"));
            tmpLinii.Add(new Linija("Kratovo", "Skopje", 200, 30, "img/Mapa_Kratovo-Skopje.jpg"));
            tmpLinii.Add(new Linija("Skopje", "Negotino", 240, 40, "img/Mapa_Skopje-Negotino.jpg"));
            Prevoznici.Add(new Prevoznik(
                "Rule Turs",
                "img/RuleTurs_logo.jpg",
                "www.sas.com.mk/RuleT.aspx",
                tmpLinii
                ));
                
                */
        }
    }
  
}
