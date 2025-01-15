Console.WriteLine("Calculati suma numerelor pozitive " +
    "dintr-un sir de numere intregi (generat in A11). " +
    "Folositi cheia “continue” pentru a sari " +
    "peste numerele negative.\r\n");


int[] arrayDeIntrare = GetRandomGeneratedArray(-10, 10);

// declaram o variabila pentru suma
int suma = 0;

// parcurgem arrayul
for (int i = 0; i < arrayDeIntrare.Length; i++)
{
    // daca numarul este negativ ignora-l
    if (arrayDeIntrare[i] < 0)
    {
        continue;
    }

    suma += arrayDeIntrare[i];
}

Console.WriteLine("Suma numerelor pozitive din array-ul primit este: " + suma);

int[] GetRandomGeneratedArray(int limitaInferioara, int limitaSuperioara)
{
    // dam numarul de elemente pentru sir
    int a;
    Console.Write("Introduceti numarul de elemente pentru sir: ");
    string aInput = Console.ReadLine();
    bool aValid = int.TryParse(aInput, out a);

    if (aValid && a <= 0)
    {
        aValid = false;
    }

    while (!aValid)
    {
        Console.WriteLine("Datele introduse nu sunt un numar intreg sau numarul este mai mic decat sau egal cu 0!");
        Console.Write("Introduceti un numar: ");
        aInput = Console.ReadLine();
        aValid = int.TryParse(aInput, out a);

        if (aValid && a <= 0)
        {
            aValid = false;
        }
    }

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

    return arrayDeNumere;
}
