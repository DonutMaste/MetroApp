using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    internal class LinkaMetraC
    {
        private int _pocetStanic;

        private List<string> _nazvyStanicC; //názvy stanic - Florenc, Pankrác, Hlavní nádraží...

        public LinkaMetraC(List<string> _vkladaneStaniceC)
        {
            _nazvyStanicC = _vkladaneStaniceC;
        }
        public void VypisStaniceC()
        {
            foreach (string stanice2 in _nazvyStanicC)
            {
                Console.WriteLine(stanice2);
            }
        }
        public void VypisPrvniC()
        {
            Console.WriteLine("První stanice: " + _nazvyStanicC[0]);
        }
        public void VypisPosledniC()
        {
            int posledni = _nazvyStanicC.Count - 1;
            Console.WriteLine($"Poslední stanice: {_nazvyStanicC[posledni]}");
        }
        public int ZjistiCas1(string prvniStaniceC, string druhaStaniceD)
        {
            int cas2 = 0;
            if (prvniStaniceC == druhaStaniceD)
            {
                Console.WriteLine("Stanice se shodují");
            }

            else
            {
                //seznam musí obsahovat obě zadané stanice
                if (_nazvyStanicC.Contains(prvniStaniceC) && _nazvyStanicC.Contains(druhaStaniceD))
                {
                    int indexPrvniD = _nazvyStanicC.IndexOf(prvniStaniceC);
                    Console.Clear();
                    int indexDruheD = _nazvyStanicC.IndexOf(druhaStaniceD);
                    Console.Clear();
                    int rozdil = indexPrvniD - indexDruheD;
                    cas2 = rozdil * 2;
                    cas2 = Math.Abs(cas2);
                }
            }

            return cas2;
        }
    }
}
