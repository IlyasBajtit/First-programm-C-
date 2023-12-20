Console.WriteLine("Entrez le capital de départ (en euros) :");
float capitalDedepart = float.Parse(Console.ReadLine());

Console.WriteLine("Entrez le taux d'intérets (en %) :");
float txInt = float.Parse(Console.ReadLine());

Console.WriteLine("Entrez la durée de l'epargne (en années) :");
float duree = float.Parse(Console.ReadLine());

double montantInterets = capitalDedepart * Math.Pow(1 + txInt / 100, duree) - capitalDedepart;
double capitalFinal = capitalDedepart + montantInterets;

Console.WriteLine($"Le montant des intérets sera de {montantInterets} euros aprés {duree} ans :");
Console.WriteLine($"Le capital final sera de {capitalFinal} :");
