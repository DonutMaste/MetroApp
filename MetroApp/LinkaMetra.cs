using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    internal class LinkaMetra
    {
        private int _pocetStanic;

        private List<string> _nazvyStanic; //názvy stanic - Florenc, Pankrác, Hlavní nádraží...

        public LinkaMetra(List<string> _vkladaneStanice)
        {
            _nazvyStanic = _vkladaneStanice;
        }
        public void VypisStanice()
        {
            foreach(string stanice in _nazvyStanic)
            {
                Console.WriteLine(stanice);
            }
        }
        public void VypisPrvni()
        {
            Console.WriteLine(_nazvyStanic[0]);
        }
        public int ZjistiCas(string prvniStanice, string druhaStanice)
        {
            int cas = 0;
            if(prvniStanice == druhaStanice)
            {
                Console.WriteLine("Stanice se shodují");
            }
            else
            {
                //seznam musí obsahovat obě zadané stanice
                if (_nazvyStanic.Contains(prvniStanice) && _nazvyStanic.Contains(druhaStanice))
                {
                    int indexPrvni = _nazvyStanic.IndexOf(prvniStanice);
                    int indexDruhe = _nazvyStanic.IndexOf(druhaStanice);
                    int rozdil = indexPrvni - indexDruhe;
                    cas = rozdil * 2;
                }
            }
            return cas;
        }
    }
}
