using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroApp;

namespace MetroApp
{
    internal class LinkaMetraA
    {
        private int _pocetStanic;

        private List<string> _nazvyStanic; //názvy stanic - Florenc, Pankrác, Hlavní nádraží...

        public LinkaMetraA(List<string> _vkladaneStanice)
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
            Console.WriteLine("První stanice: " + _nazvyStanic[0]);
        }
        public void VypisPosledni()
        {
            int posledni = _nazvyStanic.Count - 1;
            Console.WriteLine($"Poslední stanice: {_nazvyStanic[posledni]}");
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
                    Console.Clear();
                    int indexDruhe = _nazvyStanic.IndexOf(druhaStanice);
                    Console.Clear();
                    int rozdil = indexPrvni - indexDruhe;
                    cas = rozdil * 2;
                    cas = Math.Abs(cas);
                }   
            }
            
            return cas;
        }
    }
}
