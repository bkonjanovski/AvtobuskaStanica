using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtobuskaStanica
{
    [Serializable]
    public class Prevoznik
    {
        public String Ime { get; set; }
        public List<Linija> Linii { get; set; }
        public String LogoUrl { get; set; }
        public String WebStrana { get; set; }
        public Prevoznik(string Ime, string logoUrl, string webstrana, List<Linija> L)
        {
            this.Ime = Ime;
            this.LogoUrl = logoUrl;
            this.WebStrana = webstrana;
            Linii = new List<Linija>();
            this.Linii = L;
        }

        public void AddLinija(Linija l)
        {
            Linii.Add(l);
        }

        public override string ToString()
        {
            return (this.Ime);
        }
    }
}
