Console.WriteLine("A12: Dati un numar natural de la tastatura. " +
    "Numarul trebuie sa fie in intervalul definit in A11. " +
    "Cautati numarul introdus in colectia generata in A11. " +
    "Daca il gasiti, afisati poziţia lui si intrerupeti funcţionarea structurii repetitive, altfel afisati un mesaj corespunzator lipsei lui." +
    "Hint: cheia “break” intrerupe rularea unei structuri repetitive.");
Console.WriteLine();

int ObtineNumarIntregDeLaTastatura()
{
    // dam numarul de elemente pentru sir
    int a;
    Console.Write("Introduceti un numar: ");
    string aInput = Console.ReadLine();
    bool aValid = int.TryParse(aInput, out a);

    while (!aValid)
    {
        Console.Write("Datele introduse nu sunt un numar intreg! Introduceti un numar: ");
        aInput = Console.ReadLine();
        aValid = int.TryParse(aInput, out a);
    }

    return a;
}


// dam numarul de elemente pentru sir
int a = ObtineNumarIntregDeLaTastatura();

// indicati intervalul in care putem avea valori
const int limitaInferioara = -10;
const int limitaSuperioara = 10;

int[] arrayDeNumere = new int[a];

Random generatorDeNumereAleatoare = new Random();

// generam valori aleatoare pentru fiecare pozitie din array
for (int i = 0; i < arrayDeNumere.Length; i++)
{
    // atribuim un numar aleator pentru pozitia curenta din array
    arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
    Console.Write(arrayDeNumere[i] + ", ");
}

Console.WriteLine();

// ====================== Mai sus e codul copiat de la A11

// Validare date de la tastatura
int numar = ObtineNumarIntregDeLaTastatura();

while (numar > limitaSuperioara || numar < limitaInferioara)
{
    Console.WriteLine("Numarul introdus nu este in interiorul intervalului!");
    numar = ObtineNumarIntregDeLaTastatura();
}

// Cautarea pozitiei numarului citit in array
int indexGasit = -1;

for (int i = 0; i < arrayDeNumere.Length; i++)
{
    if (arrayDeNumere[i] == numar)
    {
        indexGasit = i;
        break;
    }
}

if (indexGasit > -1)
{
    Console.WriteLine($"Numarul apare prima oara pe pozitia {indexGasit}.");
}
else
{
    Console.WriteLine($"Numarul nu apare in sirul generat.");
}