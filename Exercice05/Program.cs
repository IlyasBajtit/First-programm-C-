﻿
Console.Write("Veuillez saisir un nombre: ");
double nombre1 = double.Parse(Console.ReadLine());
Console.Write("Veuillez saisir un nombre: ");
double nombre2 = double.Parse(Console.ReadLine());
double resultat = nombre1 + nombre2;
Console.WriteLine($"La somme de ces deux nombres est : {resultat}");


/*Correction:

*//* Nombre entier *//*
//Console.Write("Veuillez saisir un nombre entier : ");
//int premierNombre = int.Parse(Console.ReadLine());  // équivalent: Convert.ToInt32(Console.ReadLine());
//Console.Write("Veuillez saisir un nombre entier : ");
//int deuxiemeNombre = int.Parse(Console.ReadLine());
//int somme = premierNombre + deuxiemeNombre;
//Console.WriteLine($"La somme de ces deux nombres est : {somme}");


*//* Nombre entier *//*
Console.Write("Veuillez saisir un nombre réel : ");
double premierNombreFloat = double.Parse(Console.ReadLine());  // équivalent: Convert.ToDouble(Console.ReadLine());
Console.Write("Veuillez saisir un nombre réel : ");
double deuxiemeNombreFloat = double.Parse(Console.ReadLine());
double sommeFloat = premierNombreFloat + deuxiemeNombreFloat;
Console.WriteLine($"La somme de ces deux nombres est : {sommeFloat}");*/