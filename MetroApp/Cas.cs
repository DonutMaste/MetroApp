using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroApp;

namespace MetroApp
{
    internal class Cas
    {
        public void Main()
        {
            string cas = DateTime.Now.ToString("t");
            Console.WriteLine("Teď je {0}", cas);
        }
    }
}
