Console.WriteLine("Cititi un numar si calculati factorialul acestuia ( n! = 1*2*3*…*n).\n");

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

int produs = 1;

for (int i = 1; i <= a; i++)
{
    produs *= i;
}

Console.WriteLine($"a ({a}) factorial = {produs}");


