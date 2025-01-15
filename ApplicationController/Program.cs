using App01;
using App02;
using App03;
using App04;
using App05;
using App06;
using App07;
using App15;
using App16;
using ITSchool.AppUtilities;

namespace ApplicationController
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ApplicationBase.Applications.AddRange(
            [
                new Application01(),
                new Application02(),
                new Application03(),
                new Application04(),
                // new Application05(),
                // new Application06()
                new Application07(),
                new Application15(),
                new Application16()
            ]);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Lista aplicatiilor: ");
                Console.WriteLine();

                for (int i = 0; i < ApplicationBase.Applications.Count; i++)
                {
                    Console.Write($"{(i + 1)}: ");

                    Console.WriteLine(ApplicationBase.Applications[i].Cerinta);
                }

                Console.WriteLine("0: EXIT");

                int input = CitesteNumarDeLaTastatura(0, ApplicationBase.Applications.Count);

                // Asta inseamna EXIT
                if (input == 0)
                {
                    return;
                }

                ApplicationBase.Applications[input - 1].Launch();

                Console.WriteLine("Apasati tasta ENTER pentru a reveni la meniul anterior.");
                Console.ReadLine();
            }
        }

        static int CitesteNumarDeLaTastatura(int minim, int maxim)
        {
            Console.Write("Introdu un numar intreg de la tastatura: ");

            string aInput = Console.ReadLine();
            bool aValid = int.TryParse(aInput, out int a);

            while (!aValid || (a < minim || a > maxim)) 
            {
                Console.WriteLine("Datele introduse nu sunt corecte!");
                
                Console.Write("Introdu un numar intreg de la tastatura: ");
                aInput = Console.ReadLine();
                aValid = int.TryParse(aInput, out a);
            }

            return a;
        }
    }
}