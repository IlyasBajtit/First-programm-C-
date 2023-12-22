Console.WriteLine("--- Les suites chaînées de nombres ---\n");
Console.Write("Merce de saisir un nombre : ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Les chaînes possibles sont :");

for (double diviseur = 2; diviseur <= number; diviseur++)
{
    double mid = number / diviseur;

    if (mid % 0.5 == 0)
    {
        int debut = (int)(mid - diviseur / 2) + 1;
        if (debut <= 1)
            break;

        int fin = (int)(mid + diviseur / 2);
        Console.Write($"{number} = {debut}");
        for (int j = debut + 1; j <= fin; j++)
        {
            Console.Write("+" + j);
        }
        Console.WriteLine();
    }
}

