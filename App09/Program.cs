Console.WriteLine("Afisati toate numerele pare de la 1 la 100 folosind o bucla pentru.\r\n");

// Parcurgem toate numerele de la 1 la 100
for (int index = 1; index <= 100; index++)
{
    // Verificam daca un numar se imparte exact la 2
    if (index % 2 == 0)
    {
        Console.WriteLine($"Numarul {index} este par.");
    }
}

