using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITSchool.AppUtilities;

namespace App04
{
    public class Application04 : ApplicationBase
    {
        public Application04()
        {
            Cerinta = "Cititi doua numere si afisati daca primul este mai mare decat al doilea.";
        }

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"
            int a;
            Console.Write("Dati o valoare pentru \"a\": ");
            string aInput = Console.ReadLine();
            bool inputAValid = int.TryParse(aInput, out a);

            while (inputAValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");
                Console.Write("Dati o valoare pentru \"a\": ");
                aInput = Console.ReadLine();
                inputAValid = int.TryParse(aInput, out a);
            }

            // Inregistrare numar intreg valid de la tastatura pentru "b"
            int b;
            Console.Write("Dati o valoare pentru \"b\": ");
            string bInput = Console.ReadLine();

            bool inputBValid = int.TryParse(bInput, out b);

            while (inputBValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");
                Console.Write("Dati o valoare pentru \"b\": ");
                bInput = Console.ReadLine();
                inputBValid = int.TryParse(bInput, out b);
            }

            if (a > b)
            {
                Console.WriteLine($"{a} este mai mare decat {b}.");
            }
            else
            {
                Console.WriteLine($"{a} este mai mic decat {b}.");
            }
        }
    }
}
