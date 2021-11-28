using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra gra = new Gra();
            PokazTytulGry();
            Pytanie p1 = gra.WylosujPytanie();
            string odpGracza = PokazPytanieGraczowi(p1);
            if (odpGracza == "1")
            {
                DobraOdpowiedz(p1.Kategoria);
            }
            else
            {
                Pech();
            }

            Console.ReadLine();
        }


        static void PokazTytulGry()
        {
            Console.WriteLine("WITAJ W QUIZIE. �YCZ� POWODZENIA.");
            Console.WriteLine("Naci�nij ENTER aby rozpocz��");
            Console.ReadLine();
        }


        static string PokazPytanieGraczowi(Pytanie pytanie)
        {
            Console.Clear();
            Console.WriteLine();
            //Console.WriteLine("Pytanie za " + pytanie.Kategoria + " pkt.");
            Console.WriteLine($"Pytanie za {pytanie.Kategoria} pkt");
            Console.WriteLine();
            Console.WriteLine(pytanie.Tresc);
            Console.WriteLine();
            foreach (Odpowiedz odp in pytanie.Odpowiedzi)
            {
                Console.WriteLine($"{odp.Id}. {odp.Tresc}");
            }

            Console.WriteLine();
            Console.Write("Prosz� wybra� 1, 2, 3 lub 4: ");
            return Console.ReadLine();
        }


        static void DobraOdpowiedz(int wygrana)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, to jest dobra odpowied�");
            Console.WriteLine($"Wygrywasz {wygrana} pkt.");
        }

        static void Pech()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety, to nie jest dobra odpowied�");
            Console.WriteLine("GAME OVER");
        }
    }
}