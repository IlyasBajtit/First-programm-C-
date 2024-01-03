﻿Console.WriteLine("*** Ou est passé mon numéros ?");
int [] tab = new int [10]; 
Random aleatoire = new Random();
string chaine = "";
int nb = 0;
int index;

Console.WriteLine("Affectation de valeurs... \n");

for (int i = 0; i < tab.Length; i++)
    tab[i] = aleatoire.Next(1, 51);

Console.WriteLine("Affichage avant tirage : ");
foreach (var i in tab)
{
    Console.WriteLine(chaine + i);
    chaine += " ";
}

nb = tab[0]; 

Array.Sort(tab);
chaine = " ";
Console.WriteLine("Aprés : ");

foreach (var i in tab)
{
    Console.WriteLine(chaine + i);
    chaine += " ";
}        

index =  Array.IndexOf(tab, nb) + 1;
Console.WriteLine(Environment.NewLine);
Console.WriteLine($"Le nombre {nb} se trouvait en 1er position");
Console.WriteLine($"Il se retrouve a la position {index} aprés le tirage");
Console.Read();