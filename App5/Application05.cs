using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class Application05
    {
        public string Cerinta = "Cititi un numar si verificati daca este par sau impar.";

        public void Launch()
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

            if (a % 2 == 0)
            {
                Console.Write("Numarul este par");
            }
            else
            {
                Console.Write("Numarul este impar");
            }
        }
    }
}
