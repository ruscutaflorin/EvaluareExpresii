using System;
using System.Collections;
using System.Data;


namespace ProiectInfo
{
    class Evaluare
    {
        public int Dimensiune(string expresie)
        {
            return expresie.Length;
        }

        public int NrCuv(string expresie)
        {
            char[] separators = { ',', '.', ' ', '!', '?', '-', '+', '*', '/', '%', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] nr = expresie.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return nr.Length;
        }

        public int NrLitere(string expresie)
        {
            int cnt = 0;
            for (int i = 0; i < expresie.Length; ++i)
                if ((expresie[i] >= 'a' && expresie[i] <= 'z') || (expresie[i] >= 'A' && expresie[i] <= 'Z'))
                    ++cnt;
            return cnt;
        }

        public int NrCifre(string expresie)
        {

            int cnt = 0;
            for (int i = 0; i < expresie.Length; ++i)
                if (expresie[i] >= '0' && expresie[i] <= '9')
                    ++cnt;
            return cnt;
        }
        public int NrNumbs(string expresie)
        {

            int cnt = 0;
            char[] separators = { ',', '.', ' ', '+', '-', '*', '(', ')' };
            string[] nr = expresie.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < nr.Length; ++i)
                if (nr[i][0] >= '0' && nr[i][0] <= '9')
                    cnt++;

            return cnt;
        }
        public void EliminareSpatii(string expresie)
        {

            char[] sep = { ' ' };
            string[] nr = expresie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach (var x in nr)
                Console.Write(x + " ");
        }

        public void EliminareSpatiiSep(string expresie)
        {

            char[] sep1 = { ' ' };
            string a = ",";
            string b = ".";
            string c = "!";
            string d = "?";
            string[] nr = expresie.Split(sep1, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < (nr.Length - 1); ++i)
                if ((nr[i + 1] != a) && (nr[i + 1] != b) && (nr[i + 1] != c) && (nr[i + 1] != d)) Console.Write(nr[i] + " ");
                else
                    Console.Write(nr[i]);
            int cnt = nr.Length - 1;
            //if ((nr[cnt] == a) || (nr[cnt] == b) || (nr[cnt] == c) || (nr[cnt] == d))
            Console.Write(nr[cnt]);
        }

        public void SortareCuvinte(string expresie)
        {
            char[] sep = { ',', '.', ' ', '!', '?', '-', '+', '*', '/', '%', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] nr = expresie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            var sir = new ArrayList();
            foreach (var x in nr)
                sir.Add(x);
            sir.Sort();
            for (int i = 0; i < sir.Count; ++i)
                Console.Write(sir[i] + " ");
        }
        public void SortareNumere(string expresie)
        {
            var sir = new ArrayList();
            char[] separators = { ',', '.', ' ', '+', '-', '*', '(', ')', '/' };
            string[] nr = expresie.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < nr.Length; ++i)
                if (nr[i][0] >= '0' && nr[i][0] <= '9')
                    sir.Add(int.Parse(nr[i]));
            sir.Sort();
            for (int i = 0; i < sir.Count; ++i)
                Console.Write(sir[i] + " ");
        }
        public void SortareCuvinteLit(string expresie)
        {
            char[] sep = { ',', '.', ' ', '!', '?', '-', '+', '*', '/', '%', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] nr = expresie.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            var sir = new ArrayList();
            foreach (var x in nr)
                sir.Add(int.Parse(x));
            sir.Sort();
            for (int i = 0; i < sir.Count; ++i)
                Console.Write(sir[i] + " ");
        }

        public void CalculExpresie(string expresie)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(expresie, "");
            Console.WriteLine(v);
        }
    }
}
