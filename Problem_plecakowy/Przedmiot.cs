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
    internal class Przedmiot
    {
        bool uzycie_przedmiotu = false;
        public int waga, wartosc;
        public Przedmiot(bool u, int w, int war) 
        {
            uzycie_przedmiotu = u;
            waga = w;
            wartosc = war;
            Console.WriteLine($" {waga}           {wartosc}");
        }
        public int get_waga()
        {
            return waga;
        }
        public int get_wartosc()
        {
            return wartosc;
        }
        public void set_uzycie_przedmiotu(bool nowa_wartosc)
        {
            uzycie_przedmiotu=nowa_wartosc;
        }
    }
}
