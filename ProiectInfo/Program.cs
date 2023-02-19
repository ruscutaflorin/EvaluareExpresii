using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluare a = new Evaluare();
            string x = "3 / (22+4)-5 + 2/(1+2)";
            //string x = Console.ReadLine();
            Console.WriteLine("Sirul dumneavoastra este:\n" + x);
            //Console.WriteLine("Sirul dumneavoastra a fost rescris pentru a ocupa mai putin spatiu.\nAcum sirul dumneavoastra arata asa:\n"); a.EliminareSpatii(x); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dimensiunea sirului citit este de: " + a.Dimensiune(x));
            Console.WriteLine();
            if (a.NrLitere(x) == 0)
            {
                Console.WriteLine("Sirul nu contine niciun cuvant.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nr. de cuvinte al sirului citit este de: " + a.NrCuv(x));
                Console.WriteLine();
            }
            if (a.NrLitere(x) == 0)
            {
                Console.WriteLine("Sirul nu contine nicio litera.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nr.de litere al sirului citit este de: " + a.NrLitere(x));
                Console.WriteLine();
            }
            Console.WriteLine("Nr.de cifre al sirului citit este de: " + a.NrCifre(x));
            Console.WriteLine();
            if (a.NrLitere(x) != 0)
            {
                Console.WriteLine("In sirul dumneavoastra se afla " + a.NrNumbs(x) + " numere");
                Console.WriteLine();
            }
            if (a.NrLitere(x) > 0 && a.NrCifre(x) == 0)
            {
                Console.WriteLine("Am ordonat cuvintele din sir crescator lexicografic: ");
                a.SortareCuvinte(x);
                Console.WriteLine();
            }
            else if (a.NrLitere(x) == 0 && a.NrCifre(x) > 0)
            {
                Console.Write("Am ordonat numerele din sir crescator lexicografic: ");
                a.SortareNumere(x);
                Console.WriteLine();
            }
            else if (a.NrLitere(x) > 0 && a.NrCifre(x) > 0)
            {
                Console.WriteLine("Am ordonat cuvintele din sir crescator lexicografic");
                a.SortareCuvinte(x);
                Console.WriteLine();
                Console.Write("Am ordonat numerele din sir crescator: ");
                a.SortareNumere(x);
                Console.WriteLine();
            }
            Console.WriteLine();
            if (a.NrLitere(x) > 0)
            {
                Console.WriteLine("Sirul dumneavoastra a fost rescris.\nDaca acum sirul difera de cel initial inseamna ca la inceput acesta a avut anumite greseli:\n");
                a.EliminareSpatiiSep(x);
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (a.NrCifre(x) > 0)
            {
                Console.Write("Cum sirul dumneavoastra este reprezentat de o expresie matematica, o vom calcula.\nLa acest calcul participa " + a.NrNumbs(x) + " numere\nRezultatul obtinut este: ");
                a.CalculExpresie(x);
                Console.WriteLine();
            }

            Console.Write("\n\n");

            Evaluare b = new Evaluare();
            string y = "Astazi voi lua nota mare la     informatica  ,      cel putin      asa sper    , mai iau un 3 la mate     si un 5 la franceza    si sunt boss   .";
            //string x = Console.ReadLine();
            Console.WriteLine("Sirul dumneavoastra este:\n" + y);
            //Console.WriteLine("Sirul dumneavoastra a fost rescris pentru a ocupa mai putin spatiu.\nAcum sirul dumneavoastra arata asa:\n"); a.EliminareSpatii(x); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dimensiunea sirului citit este de: " + a.Dimensiune(y));
            Console.WriteLine();
            if (a.NrLitere(y) == 0)
            {
                Console.WriteLine("Sirul nu contine niciun cuvant.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nr. de cuvinte al sirului citit este de: " + a.NrCuv(y));
                Console.WriteLine();
            }
            if (a.NrLitere(y) == 0)
            {
                Console.WriteLine("Sirul nu contine nicio litera.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nr.de litere al sirului citit este de: " + a.NrLitere(y));
                Console.WriteLine();
            }
            Console.WriteLine("Nr.de cifre al sirului citit este de: " + a.NrCifre(y));
            Console.WriteLine();
            if (a.NrLitere(y) != 0)
            {
                Console.WriteLine("In sirul dumneavoastra se afla " + a.NrNumbs(y) + " numere");
                Console.WriteLine();
            }
            if (a.NrLitere(y) > 0 && a.NrCifre(y) == 0)
            {
                Console.WriteLine("Am ordonat cuvintele din sir crescator lexicografic");
                a.SortareCuvinte(y);
                Console.WriteLine();
            }
            else if (a.NrLitere(y) == 0 && a.NrCifre(y) > 0)
            {
                Console.Write("Am ordonat numerele din sir crescator lexicografic: ");
                a.SortareNumere(y);
                Console.WriteLine();
            }
            else if (a.NrLitere(y) > 0 && a.NrCifre(y) > 0)
            {
                Console.WriteLine("Am ordonat cuvintele din sir crescator lexicografic");
                a.SortareCuvinte(y);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Am ordonat numerele din sir crescator: ");
                a.SortareNumere(y);
                Console.WriteLine();
            }
            Console.WriteLine();
            if (a.NrLitere(y) > 0)
            {
                Console.WriteLine("Sirul dumneavoastra a fost rescris.\nDaca acum sirul difera de cel initial inseamna ca la inceput acesta a avut anumite greseli:\n");
                a.EliminareSpatiiSep(y);
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (a.NrCifre(y) > 0)
            {
                Console.Write("Cum sirul dumneavoastra este reprezentat de o expresie matematica, o vom calcula.\nLa acest calcul participa " + a.NrNumbs(y) + " numere\nRezultatul obtinut este: ");
                a.CalculExpresie(y);
                Console.WriteLine();
            }
        }
    }
}
