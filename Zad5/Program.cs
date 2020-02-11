using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wierzchołek> Graf = new List<Wierzchołek>();
            List<Krawędź> Krawędzie = new List<Krawędź>();


            Graf.Add(new Wierzchołek(0));
            Graf.Add(new Wierzchołek(1));
            Graf.Add(new Wierzchołek(2));
            Graf.Add(new Wierzchołek(3));
            //Graf.Add(new Wierzchołek(4));
            //Graf.Add(new Wierzchołek(5));
            //Graf.Add(new Wierzchołek(6));
            //Graf.Add(new Wierzchołek(7));
            //Graf.Add(new Wierzchołek(8));

            //GrafPierwszy 5 wierzchołków
            //Krawędzie.Add(new Krawędź(0, 1));
            //Krawędzie.Add(new Krawędź(0, 3));
            //Krawędzie.Add(new Krawędź(1, 2));
            //Krawędzie.Add(new Krawędź(2, 3));
            //Krawędzie.Add(new Krawędź(2, 4));
            //Krawędzie.Add(new Krawędź(3, 4));

            //GrafDrugi 4 wierzchołki
            Krawędzie.Add(new Krawędź(0, 3));
            Krawędzie.Add(new Krawędź(2, 3));
            Krawędzie.Add(new Krawędź(1, 2));

            //GrafTrzeci 6 wierzchołków
            //Krawędzie.Add(new Krawędź(0, 1));
            //Krawędzie.Add(new Krawędź(1, 2));
            //Krawędzie.Add(new Krawędź(1, 3));
            //Krawędzie.Add(new Krawędź(1, 4));
            //Krawędzie.Add(new Krawędź(2, 3));
            //Krawędzie.Add(new Krawędź(2, 4));
            //Krawędzie.Add(new Krawędź(3, 4));
            //Krawędzie.Add(new Krawędź(4, 5));

            //GrafCzwarty 9 wierzchołków
            //Krawędzie.Add(new Krawędź(0, 1));
            //Krawędzie.Add(new Krawędź(0, 2));
            //Krawędzie.Add(new Krawędź(0, 3));
            //Krawędzie.Add(new Krawędź(0, 4));
            //Krawędzie.Add(new Krawędź(0, 6));
            //Krawędzie.Add(new Krawędź(0, 7));
            //Krawędzie.Add(new Krawędź(0, 8));
            //Krawędzie.Add(new Krawędź(1, 2));
            //Krawędzie.Add(new Krawędź(1, 3));
            //Krawędzie.Add(new Krawędź(1, 4));
            //Krawędzie.Add(new Krawędź(1, 5));
            //Krawędzie.Add(new Krawędź(1, 6));
            //Krawędzie.Add(new Krawędź(1, 8));
            //Krawędzie.Add(new Krawędź(2, 3));
            //Krawędzie.Add(new Krawędź(2, 4));
            //Krawędzie.Add(new Krawędź(2, 5));
            //Krawędzie.Add(new Krawędź(2, 7));
            //Krawędzie.Add(new Krawędź(2, 8));
            //Krawędzie.Add(new Krawędź(3, 6));
            //Krawędzie.Add(new Krawędź(3, 7));
            //Krawędzie.Add(new Krawędź(3, 8));
            //Krawędzie.Add(new Krawędź(4, 5));
            //Krawędzie.Add(new Krawędź(4, 6));
            //Krawędzie.Add(new Krawędź(4, 8));
            //Krawędzie.Add(new Krawędź(5, 7));
            //Krawędzie.Add(new Krawędź(5, 8));
            //Krawędzie.Add(new Krawędź(6, 7));
            //Krawędzie.Add(new Krawędź(6, 8));
            //Krawędzie.Add(new Krawędź(7, 8));

            //GrafPiąty 9 wierzchołków
            //Krawędzie.Add(new Krawędź(0, 1));
            //Krawędzie.Add(new Krawędź(0, 3));
            //Krawędzie.Add(new Krawędź(0, 4));
            //Krawędzie.Add(new Krawędź(1, 2));
            //Krawędzie.Add(new Krawędź(1, 3));
            //Krawędzie.Add(new Krawędź(1, 5));
            //Krawędzie.Add(new Krawędź(1, 6));
            //Krawędzie.Add(new Krawędź(2, 3));
            //Krawędzie.Add(new Krawędź(2, 4));
            //Krawędzie.Add(new Krawędź(2, 5));
            //Krawędzie.Add(new Krawędź(2, 7));
            //Krawędzie.Add(new Krawędź(3, 4));
            //Krawędzie.Add(new Krawędź(3, 6));
            //Krawędzie.Add(new Krawędź(3, 7));
            //Krawędzie.Add(new Krawędź(4, 5));
            //Krawędzie.Add(new Krawędź(4, 6));
            //Krawędzie.Add(new Krawędź(4, 8));
            //Krawędzie.Add(new Krawędź(5, 6));
            //Krawędzie.Add(new Krawędź(5, 7));
            //Krawędzie.Add(new Krawędź(5, 8));
            //Krawędzie.Add(new Krawędź(6, 7));
            //Krawędzie.Add(new Krawędź(7, 8));

            //GrafSzósty 6 wierzchołków
            //Krawędzie.Add(new Krawędź(0, 1));
            //Krawędzie.Add(new Krawędź(0, 3));
            //Krawędzie.Add(new Krawędź(0, 4));
            //Krawędzie.Add(new Krawędź(1, 2));
            //Krawędzie.Add(new Krawędź(1, 4));
            //Krawędzie.Add(new Krawędź(1, 5));
            //Krawędzie.Add(new Krawędź(2, 5));
            //Krawędzie.Add(new Krawędź(3, 4));
            //Krawędzie.Add(new Krawędź(4, 5));


            int LiczbaWierzchołkówGrafu = Graf.Count;
            int LiczbaKrawędziGrafu = Krawędzie.Count;

            int licznikOperacjiElementarnych = 0;

            foreach (var wierzchołek in Graf)
            {
                foreach (var krawędź in Krawędzie)
                {
                    if (krawędź.A == wierzchołek.Nr && krawędź.B != wierzchołek.Nr) 
                        wierzchołek.Sąsiedzi.Add(krawędź.B);
                    if (krawędź.A != wierzchołek.Nr && krawędź.B == wierzchołek.Nr)
                        wierzchołek.Sąsiedzi.Add(krawędź.A);
                }
            }

            Graf = Graf.OrderBy(x => x.Sąsiedzi.Count).ToList();
            Graf.Reverse();


            int[] PaletaBarw = new int[Graf.Count];
            for (int i = 0; i < PaletaBarw.Length; i++)
            {
                licznikOperacjiElementarnych++;
                PaletaBarw[i] = i+1;
            }

            foreach (var wierzchołek in Graf)
            {
                List<int> koloryDostępne = new List<int>();
                foreach (var item in PaletaBarw)
                {
                    licznikOperacjiElementarnych++;
                    koloryDostępne.Add(item);
                }
                
                foreach(int sąsiad in wierzchołek.Sąsiedzi)
                {
                    licznikOperacjiElementarnych++;
                    Wierzchołek w = Graf.Find(x => x.Nr == sąsiad);
                    koloryDostępne.Remove(w.Kolor);

                }
                wierzchołek.Kolor = koloryDostępne[0];
            }

            List<int> LiczbaChromatyczna = new List<int>();
            foreach (var item in Graf)
            {
                LiczbaChromatyczna.Add(item.Kolor);
            }
            LiczbaChromatyczna = LiczbaChromatyczna.Distinct().ToList();

            Console.WriteLine("Kolory:");
            foreach (var item in Graf)
            {
                Console.WriteLine("Wierzchołek: {0} Kolor: {1}", item.Nr, item.Kolor);
            }
            Console.WriteLine("Liczba wierzchołków: " + LiczbaWierzchołkówGrafu);
            Console.WriteLine("Liczba krawędzi: " + LiczbaKrawędziGrafu);
            Console.WriteLine("Liczba chromatyczna grafu = " + LiczbaChromatyczna.Count);
            Console.WriteLine("Liczba operacji elementarynch = " + licznikOperacjiElementarnych);
            Console.ReadKey();







        }
    }
}
