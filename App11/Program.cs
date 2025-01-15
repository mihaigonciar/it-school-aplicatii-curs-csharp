Console.WriteLine("A11: Realizati un generator de numere naturale aleatoare. " +
    "Veti indica numarul de elemente si intervalul in care acestea pot avea valori. " +
    "Valorile vor fi stocate intr-un array iar la final vor fi afisate in consola." +
    "Hint: Documentati-va cum putem genera numere aleatoare in C#.");

// dam numarul de elemente pentru sir
int a;
Console.Write("Introduceti numarul de elemente pentru sir: ");
string aInput = Console.ReadLine();
bool aValid = int.TryParse(aInput, out a);

while (!aValid)
{
    Console.Write("Datele introduse nu sunt un numar intreg! Introduceti un numar: ");
    aInput = Console.ReadLine();
    aValid = int.TryParse(aInput, out a);
}

// indicati intervalul in care putem avea valori
const int limitaInferioara = -10;
const int limitaSuperioara = 10;

int[] arrayDeNumere = new int[a];

Random generatorDeNumereAleatoare = new Random();

// generam valori aleatoare pentru fiecare pozitie din array
for(int i = 0; i < arrayDeNumere.Length; i++)
{
    // atribuim un numar aleator pentru pozitia curenta din array
    arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
}