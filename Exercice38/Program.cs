Console.WriteLine("*** Ou est passé mon numéros ?");
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
    Console.WriteLine(chaine + 1);
    chaine += " ";
}

nb = tab[0]; 
