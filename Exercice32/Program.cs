int[] tab = new int[10];
string chaine = "";

Console.WriteLine("Insertions des valeurs du tableau: ");

for (int i = 0; i < tab.Length; i++)
{
    Console.Write("Saisir la valeur " + (i + 1) + " ");
    if (int.TryParse(Console.ReadLine(), out int nombre))
    {
        tab[i] = nombre;
    }
    else
    {
        Console.WriteLine("Veuillez entrer une valeur numérique.");
        i--; // Permet à l'utilisateur de réessayer pour la même position
    }
}

Console.WriteLine("Affichage des valeurs du tableau");

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine(chaine + tab[i]);
    chaine += "\t";
}
