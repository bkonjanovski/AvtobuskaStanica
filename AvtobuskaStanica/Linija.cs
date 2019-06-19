using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtobuskaStanica
{
    [Serializable]
    public class Linija
    {
        public String PocetnaDestinacija { get; set; }
        public String KrajnaDestinacija { get; set; }
        public int Cena { get; set; }
        public int SlobodniMesta { get; set; }
        public String MapaUrl { get; set; }

        public Linija(string Pocetna, string Krajna, int Cena, int Slobodni, String Mapa)
        {
            this.PocetnaDestinacija = Pocetna;
            this.KrajnaDestinacija = Krajna;
            this.Cena = Cena;
            this.SlobodniMesta = Slobodni;
            this.MapaUrl = Mapa;
        }

        public override string ToString()
        {
            return this.PocetnaDestinacija + " - " + this.KrajnaDestinacija;
        }
    }
}
