using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroApp;

namespace MetroApp
{
    internal class LinkaMetraB
    {
        private int _pocetStanic;

        private List<string> _nazvyStanic; //názvy stanic - Florenc, Pankrác, Hlavní nádraží...

        public LinkaMetraB(List<string> _vkladaneStanice)
        {
            _nazvyStanic = _vkladaneStanice;
        }
        public void VypisStaniceB()
        {
            foreach (string stanice in _nazvyStanic)
            {
                Console.WriteLine(stanice);
            }
        }
        public void VypisPrvniB()
        {
            Console.WriteLine("První stanice: " + _nazvyStanic[0]);
        }
        public void VypisPosledniB()
        {
            int posledni = _nazvyStanic.Count - 1;
            Console.WriteLine($"Poslední stanice: {_nazvyStanic[posledni]}");
        }
        public int ZjistiCas(string prvniStaniceB, string druhaStaniceB)
        {
            int cas4 = 0;
            if (prvniStaniceB == druhaStaniceB)
            {
                Console.WriteLine("Stanice se shodují");
            }

            else
            {
                //seznam musí obsahovat obě zadané stanice
                if (_nazvyStanic.Contains(prvniStaniceB) && _nazvyStanic.Contains(druhaStaniceB))
                {
                    int indexPrvniB = _nazvyStanic.IndexOf(prvniStaniceB);
                    Console.Clear();
                    int indexDruheB = _nazvyStanic.IndexOf(druhaStaniceB);
                    Console.Clear();
                    int rozdil = indexPrvniB - indexDruheB;
                    cas4 = rozdil * 2;
                    cas4 = Math.Abs(cas4);
                }
            }

            return cas4;
        }
    }
}


