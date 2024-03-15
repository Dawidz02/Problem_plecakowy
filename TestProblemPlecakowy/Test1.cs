using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;

namespace TestProblemPlecakowy
{
    [TestClass]
    public class Test1
    {
        //Sprawdzenie konstruktora
        [TestMethod]
        public void TestKonstruktoraPrzedmiotu()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 1, 2);

            //weryfikacja - assert
            Assert.AreEqual(1, a.get_waga(),"niezgodnosc w wadze");
            Assert.AreEqual(2, a.get_wartosc(), "niezgodnosc w wartosci");
        }

        //Sprawdzenie, czy jeœli co najmniej jeden przedmiot spe³nia ograniczenia, to zwrócono co naj-
        //mniej jeden element.
        
                [TestMethod]
        public void test_1_przedmiot()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 4, 1);
            Przedmiot b = new Przedmiot(false, 2, 2);
            Problem testowy = new Problem(3, 1);
            testowy.listaPrzedmiotow[0] = a;
            testowy.listaPrzedmiotow[1] = b;
            testowy.listaPrzedmiotow[2] = b;
            testowy.Solve(5);
            //weryfikacja - assert
            Assert.AreEqual(0, testowy.spakowane_przedmioty[0], "Test 1 nieudany");
            Assert.AreEqual(1, testowy.spakowane_przedmioty[1], "Test 1 nieudany");
        }

        //Sprawdzenie, czy jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie.
        [TestMethod]
        public void test_0_przedmiotow()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 4, 1);
            Przedmiot b = new Przedmiot(false, 2, 2);
            Problem testowy = new Problem(3, 1);
            testowy.listaPrzedmiotow[0] = a;
            testowy.listaPrzedmiotow[1] = b;
            testowy.listaPrzedmiotow[2] = b;
            testowy.Solve(1);
            //weryfikacja - assert
            Assert.AreEqual(0, testowy.spakowane_przedmioty.Count, "Test 2 nieudany");
        }

        //Sprawdzenie, czy kolejnoœæ przedmiotów ma wp³ywa na znalezione rozwi¹zanie.
        [TestMethod]
        public void test_kolejnosc()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 4, 1);
            Przedmiot b = new Przedmiot(false, 2, 2);
            Problem testowy = new Problem(3, 1);
            testowy.listaPrzedmiotow[0] = a;
            testowy.listaPrzedmiotow[1] = b;
            testowy.listaPrzedmiotow[2] = b;
            testowy.Solve(5);
            Problem testowy_2 = new Problem(3, 1);
            testowy_2.listaPrzedmiotow[0] = b;
            testowy_2.listaPrzedmiotow[1] = a;
            testowy_2.listaPrzedmiotow[2] = b;
            testowy_2.Solve(5);
            //weryfikacja - assert
            Assert.AreEqual(testowy_2.spakowane_przedmioty[1], testowy.spakowane_przedmioty[1], "Test 3 nieudany");
            Assert.AreEqual(testowy_2.spakowane_przedmioty[0], testowy.spakowane_przedmioty[0], "Test 3 nieudany");
            Assert.AreEqual(testowy_2.spakowane_przedmioty.Count, testowy.spakowane_przedmioty.Count, "Test 3 nieudany");
        }

        //Sprawdzenie poprawnoœci wyniku dla konkretnej instancji.
        [TestMethod]
        public void test_poprawnosc_obliczen()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 3, 1);
            Przedmiot b = new Przedmiot(false, 5, 7);
            Przedmiot c = new Przedmiot(false, 6, 4);
            Przedmiot d = new Przedmiot(false, 4, 9);
            Przedmiot e = new Przedmiot(false, 1, 6);
            Problem testowy = new Problem(5, 1);
            testowy.listaPrzedmiotow[0] = a;
            testowy.listaPrzedmiotow[1] = b;
            testowy.listaPrzedmiotow[2] = c;
            testowy.listaPrzedmiotow[3] = d;
            testowy.listaPrzedmiotow[4] = e;
            testowy.Solve(12);
            //weryfikacja - assert
            Assert.AreEqual(3, testowy.spakowane_przedmioty.Count, "Test 4 nieudany");
            Assert.AreEqual(0, testowy.spakowane_przedmioty[0], "Test 4 nieudany");
            Assert.AreEqual(1, testowy.spakowane_przedmioty[1], "Test 4 nieudany");
            Assert.AreEqual(2, testowy.spakowane_przedmioty[2], "Test 4 nieudany");
            Assert.AreEqual(22, testowy.laczna_wartosc_przed, "Test 4 nieudany");
        }

        //Sprawdza czy przy wybraniu 0 pojemnosci plecaka program sie psuje
        [TestMethod]
        public void test_moj_0_pojemnosc()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Przedmiot a = new Przedmiot(false, 4, 3);
            Problem testowy = new Problem(1, 1);
            testowy.listaPrzedmiotow[0] = a;
            Assert.AreEqual(0, testowy.spakowane_przedmioty.Count);
        }

        //Sprawdza czy przy wybraniu zerowej liczby przedmiotów lista ma dlugosc 0
        [TestMethod]
        public void test_moj_0_przedmiotow()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Problem testowy = new Problem(0, 1);
            Assert.AreEqual(0, testowy.listaPrzedmiotow.Count);
        }

        //Sprawdzenie czy wielokrotne uzycie tego samego seeda zmienia wartosci na przedmiotach
        [TestMethod]
        public void test_moj_toSamoZiarno()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Problem testowy = new Problem(5, 3); Problem testowy_2 = new Problem(5, 3);
            testowy.Solve(13); testowy_2.Solve(13);
            //weryfikacja - assert
            Assert.AreEqual(testowy.laczna_wartosc_przed, testowy_2.laczna_wartosc_przed);
            Assert.AreEqual(20, testowy.laczna_wartosc_przed);
        }

        //Sprawdzenie czy dla wysokich wartosc program dziala poprawnie
        [TestMethod]
        public void test_moj_wysokie_wartosci()
        {
            //przygotowanie - arrange
            //dzia³anie - act
            Problem testowy = new Problem(1000000, 3); Problem testowy_2 = new Problem(1000000, 3);
            testowy.Solve(2000000); testowy_2.Solve(2000000);
            //weryfikacja - assert
            Assert.AreEqual(testowy.laczna_wartosc_przed, testowy_2.laczna_wartosc_przed);
        }
    }
}