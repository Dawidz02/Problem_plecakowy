using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:
InternalsVisibleTo("TestProblemPlecakowy"), InternalsVisibleTo("WinFormsPlecak")]

namespace Problem_plecakowy
{
    internal class Problem
    {
        public int liczba_przedmiotow;
        public List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>();

        public int laczna_wartosc_przed, zajete_miejsce;
        public List<int> spakowane_przedmioty = new List<int>();

        public Problem(int l_przed, int seed) 
        {
            liczba_przedmiotow = l_przed;

            Console.WriteLine("Dostepne przedmioty:");
            Console.WriteLine("Waga      Wartosc");
            Random random = new Random(seed);
            for (int i = 0; i < l_przed; i++)
            {
                listaPrzedmiotow.Add(new Przedmiot(false, random.Next(1,10), random.Next(1,10)));
            }
        }

        public Result Solve(int pojemnosc)
        {
            // Sortowanie 
            listaPrzedmiotow = listaPrzedmiotow.OrderBy(p => (float)p.get_wartosc() / p.get_waga()).ToList();
            listaPrzedmiotow.Reverse();


            Console.WriteLine("\n\nPosegregowane przedmioty:");
            Console.WriteLine("Nr przedmiotu      Waga      Wartosc      Stosunek war/wag");

            // Wyswietlanie
            int w, war;
            for (int i = 0; i < liczba_przedmiotow; i++)
            {
                w = listaPrzedmiotow[i].get_waga();
                war = listaPrzedmiotow[i].get_wartosc();
                Console.WriteLine($"    [{i}]              {w}          {war}                {(float) war / w}");
            }
            
            // Wkladanie przedmiotow do plecaka
            for(int i = 0; i < liczba_przedmiotow; i++)
            {
                if (listaPrzedmiotow[i].get_waga() <= (pojemnosc - zajete_miejsce))
                {
                    laczna_wartosc_przed += listaPrzedmiotow[i].get_wartosc();
                    zajete_miejsce += listaPrzedmiotow[i].get_waga();
                    spakowane_przedmioty.Add(i);
                    listaPrzedmiotow[i].set_uzycie_przedmiotu(true);
                }
            }

            Result wynik = new Result(spakowane_przedmioty, laczna_wartosc_przed, zajete_miejsce);
            Console.WriteLine(wynik.ToString());
            return wynik;
        }
    }
}
