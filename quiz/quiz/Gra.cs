using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Gra
    {
        public void StworzListePytan()
        {

        }

        public Pytanie WylosujPytanie()
        {
            Pytanie p = new Pytanie();
            p.Id = 1;
            p.Tresc = "Jak miał na imię Einstein?";
            p.Kategoria = 500;

            Odpowiedz o1 = new Odpowiedz();
            o1.Id = 1;
            o1.Tresc = "Albert";
            o1.CzyPrawidlowa = true;
            p.Odpowiedzi.Add(o1);

            Odpowiedz o2 = new Odpowiedz();
            o2.Id = 2;
            o2.Tresc = "Andrew";
            p.Odpowiedzi.Add(o2);

            Odpowiedz o3 = new Odpowiedz();
            o3.Id = 3;
            o3.Tresc = "Aaron";
            p.Odpowiedzi.Add(o3);

            Odpowiedz o4 = new Odpowiedz();
            o4.Id = 4;
            o4.Tresc = "Anthony";
            p.Odpowiedzi.Add(o4);

            return p;
        }
    }
}