﻿Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---");


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

Correction:

Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---\n");
Console.Write("Entrez la longueur du côté AB (en cm): ");
float coteAB = float.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du côté BC (en cm): ");
float coteBC = float.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du côté CA (en cm): ");
float coteCA = float.Parse(Console.ReadLine());

// possible de faire un contrôle de saisie (Tryparse, >0)

if (coteAB == coteBC && coteAB == coteCA)
{
    Console.WriteLine("Le triangle ABC est équilatéral.");
}
else if (coteAB == coteBC)
{
    Console.WriteLine("Le triangle ABC est isocèle en B.");
}
else if (coteAB == coteCA)
{
    Console.WriteLine("Le triangle ABC est isocèle en A.");
}
else if (coteCA == coteBC)
{
    Console.WriteLine("Le triangle ABC est isocèle en C.");
}
else
{
    Console.WriteLine("Le triangle est quelconque.");
}

if (coteAB == coteBC)
    if (coteCA == coteBC)
        Console.WriteLine("Le triangle ABC est équilatéral.");
    else
        Console.WriteLine("Le triangle ABC est isocèle en B.");
else if (coteAB == coteCA)
    Console.WriteLine("Le triangle ABC est isocèle en A.");
else if (coteCA == coteBC)
    Console.WriteLine("Le triangle ABC est isocèle en C.");
else
    Console.WriteLine("Le triangle est quelconque.");