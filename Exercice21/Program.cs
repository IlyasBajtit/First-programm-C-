Console.WriteLine("--- Menus et sous-menus ---");

Console.WriteLine("Table des matières :");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("\t\t Chapitre" + i);

    for (int j = 1; j <= 3; j++)
        Console.WriteLine("\t\t -Partie" + j + "." + j);

}


/*Correction:

for (int chapitre = 1; chapitre <= 3; chapitre++)
{
    Console.WriteLine("Chapitre " + chapitre);
    for (int partie = 1; partie <= 3; partie++)
        Console.WriteLine($"\t-Partie {chapitre}.{partie}");
}
*/