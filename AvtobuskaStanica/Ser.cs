using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AvtobuskaStanica
{
    [Serializable]
    public class Ser
    {
        public List<Prevoznik> lista;
        public Ser(List<Prevoznik> list)
        {
            lista = new List<Prevoznik>();
           foreach(Prevoznik p in list)
            {
                lista.Add(p);
            }
            
        }
    }
}
