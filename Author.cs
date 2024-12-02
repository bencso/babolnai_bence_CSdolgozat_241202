using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babolnai_bence_dolgozat_241202
{
    internal class Author
    {
        public string nev;
        public string VezetekNev { get; set; }
        public string KeresztNev {  get; set; }

        public string Nev
        {
            get
            {
                return Nev;
            }

            set
            {
                if (KeresztNev.Length < 3 && KeresztNev.Length > 32) return;
                if (VezetekNev.Length < 3 && VezetekNev.Length > 32) return;
                Nev = value;
            }
        }
        public Guid guid { get; set; }

        public Author(string iNev)
        {
            guid = Guid.NewGuid();
            KeresztNev = iNev.Split(" ")[0];
            VezetekNev = iNev.Split(" ")[1];
        }
    }
}
