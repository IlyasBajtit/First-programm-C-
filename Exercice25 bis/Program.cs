Console.WriteLine("Entrez la hauteur du sapin de Noël :");
int hauteur;

// Lire la hauteur depuis l'entrée utilisateur et la convertir en entier
if (!int.TryParse(Console.ReadLine(), out hauteur) || hauteur < 1)
{
    Console.WriteLine("Veuillez entrer un nombre entier positif.");
    return;
}

// Boucle pour chaque ligne du sapin
for (int i = 0; i < hauteur; i++)
{
    // Imprimer les espaces
    for (int j = 0; j < hauteur - i - 1; j++)
    {
        Console.Write(" ");
    }

    // Imprimer les étoiles
    for (int j = 0; j < (2 * i) + 1; j++)
    {
        Console.Write("*");
    }

    // Passer à la ligne suivante
    Console.WriteLine();
}