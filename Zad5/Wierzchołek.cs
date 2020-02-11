using System;
using System.Collections.Generic;
using System.Text;

namespace Zad5
{
    public class Wierzchołek
    {
        public int Nr { get; set; }
        public int Kolor { get; set; }

        public List<int> Sąsiedzi;

        public Wierzchołek(int nr)
        {
            this.Nr = nr;
            Sąsiedzi = new List<int>();
        }
    }
}
