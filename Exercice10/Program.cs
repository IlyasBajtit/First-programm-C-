Console.WriteLine("--- La lettre est-elle une voyelle ?");

Console.Write("Entrez une lettre : ");
string lettre = Console.ReadLine().ToUpper();
if (lettre == "A" || lettre == "E" || lettre == "I" || lettre == "O" || lettre == "U" || lettre == "Y")
{
    Console.Write("Cette lettre est une voyelle !");
}
else
{
    Console.Write("Cette lettre est une consonne !");
}
