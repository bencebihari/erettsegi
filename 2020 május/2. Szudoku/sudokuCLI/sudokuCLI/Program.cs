using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> sudoku_list = new List<string>();
            StreamReader sr = new StreamReader("feladvanyok.txt");
            string line;
            while ((line = sr.ReadLine()) !=null)
            {
                sudoku_list.Add(line);
            }

            Console.WriteLine("3.feladat");
            Console.WriteLine(sudoku_list.Count + " feladvány található benne");
            Console.WriteLine("");
            Console.WriteLine("4.feladat");
            Console.WriteLine("milyen legyen a mérete (4≤x≤9)?:");
            int meret = Convert.ToInt32(sr.ReadLine());
            if (meret < 3 || meret>10)
            {
                Console.WriteLine("Ez így nem jó kérlek add meg újra!");
                meret = Convert.ToInt32(sr.ReadLine());
            }

            int darab =0;

            for (int i = 0; i < sudoku_list.Count; i++)
            {
                if (meret==line.Count())
                {
                    darab++;
                }               
            }
            Console.WriteLine(darab);

        }
    }
}
