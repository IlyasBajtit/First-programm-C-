string[] moisAnnee = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
Console.WriteLine("Enumeration du tableau");

string chaine = "";
foreach (string mois in moisAnnee)
{
    Console.WriteLine(chaine + mois);
    chaine += "\t";

}