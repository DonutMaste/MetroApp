using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroApp;

namespace MetroApp
{
    internal class LinkaMetraD
    {
        private int _pocetStanic;

        private List<string> _nazvyStanicD; //názvy stanic - Florenc, Pankrác, Hlavní nádraží...

        public LinkaMetraD(List<string> _vkladaneStaniced)
        {
            _nazvyStanicD = _vkladaneStaniced;
        }
        public void VypisStaniceD()
        {
            foreach (string stanice2 in _nazvyStanicD)
            {
                Console.WriteLine(stanice2);
            }
        }
        public void VypisPrvniD()
        {
            Console.WriteLine("První stanice: " + _nazvyStanicD[0]);
        }
        public void VypisPosledni()
        {
            int posledni = _nazvyStanicD.Count - 1;
            Console.WriteLine($"Poslední stanice: {_nazvyStanicD[posledni]}");
        }
        public int ZjistiCas1(string prvniStaniceD, string druhaStaniceD)
        {
            int cas2 = 0;
            if (prvniStaniceD == druhaStaniceD)
            {
                Console.WriteLine("Stanice se shodují");
            }

            else
            {
                //seznam musí obsahovat obě zadané stanice
                if (_nazvyStanicD.Contains(prvniStaniceD) && _nazvyStanicD.Contains(druhaStaniceD))
                {
                    int indexPrvniD = _nazvyStanicD.IndexOf(prvniStaniceD);
                    Console.Clear();
                    int indexDruheD = _nazvyStanicD.IndexOf(druhaStaniceD);
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
    

