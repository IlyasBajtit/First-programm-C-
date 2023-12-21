Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---");


Console.Write("Entrez la longueur du segment AB : ");
double longueurAB = double.Parse(Console.ReadLine());

Console.Write("Entrez la longueurdu segment BC : ");
double longueurBC = double.Parse(Console.ReadLine());

Console.Write("Entrez la longueur du segment CA : ");
double longueurAC = double.Parse(Console.ReadLine());


Console.WriteLine(" ");
if (longueurAB == longueurBC && longueurAB == longueurAC && longueurAC == longueurBC);
{
    Console.Write("Le triangle est équilateral");
}

