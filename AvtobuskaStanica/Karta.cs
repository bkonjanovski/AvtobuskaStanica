 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtobuskaStanica
{
    [Serializable]
    public class Karta
    {
        public string Relacija { get; set; }
        public string Prevoznik { get; set; }
        public int Kolichina { get; set; }
        public bool Chekirana { get; set; }
        public bool Povratna { get; set; }
        public bool Studentska { get; set; }

        public Karta(String prevoznik, String relacija, int kolichina, bool chekirana, bool povratna, bool studentska)
        {
            this.Prevoznik = prevoznik;
            this.Relacija = relacija;
            Kolichina = kolichina;
            Chekirana = chekirana;
            Povratna = povratna;
            Studentska = studentska;
        }

        public override string ToString()
        {
            string cekirna;
            string povratna;
            string studentska;
            if (Chekirana)
                cekirna = "Cekirana";
            else
                cekirna = "Necekirana";

            if (Studentska)
                studentska = "Studentska";
            else
                studentska = "Obicha";

            if (Povratna)
                povratna = "Povratna";
            else
                povratna = "Vo edna nasoka";

            return this.Prevoznik + "\t" + Relacija + "\t" + Kolichina.ToString() + "\t" + cekirna + "\t" + studentska + "\t" + povratna;
        }
    }
}
