﻿using ITSchool.AppUtilities;

namespace App07
{
    public class Application07 : ApplicationBase
    {
        public Application07()
        {
            Cerinta = "Cititi un numar n si calculati suma primelor n numere naturale.";
        }

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "n"
            int n;
            Console.Write("Dati o valoare pentru \"n\": ");
            string nInput = Console.ReadLine();
            bool inputValid = int.TryParse(nInput, out n);

            int suma = 0;

            while (inputValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");
                Console.Write("Dati o valoare pentru \"n\": ");
                nInput = Console.ReadLine();
                inputValid = int.TryParse(nInput, out n);
            }

            for (int i = 0; i <= n; i++)
            {
                suma += i;
            }

            Console.WriteLine($"Suma primelor n numere naturale este {suma}");
        }
    }
}
