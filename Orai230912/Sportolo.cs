using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai230912
{
    class Sportolo
    {
        public string Nev { get; set; }
        public bool Kategoria { get; set; }
        public string Egyesulet { get; set; }
        public int[] Pontszamok { get; set; }

        public Sportolo(string r)
        {
            var v = r.Split(';');
            Nev = v[0];
            Kategoria = v[1] == "Felnott ferfi";
        }
    }
}
