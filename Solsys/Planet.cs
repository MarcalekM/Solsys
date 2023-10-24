using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solsys
{
    internal class Planet
    {
        public string Nev { get; set; }
        public int Holdak { get; set; }
        public double   Terfogat { get; set; }

        public  Planet(string s)
        {
            var v = s.Split(';');
            Nev = v[0];
            Holdak = int.Parse(v[1]);
            Terfogat = double.Parse(v[2]);
        }
    }
}
