Console.WriteLine(" Calcul de la longeur de l'hypothénuse");

Console.Write("Entrez la largeur du premier coté (en cm): ");
double PremierCote = double.Parse(Console.ReadLine());

Console.Write("Entrez la largeur du premier coté (en cm): ");
double DeuxiemeCote = double.Parse(Console.ReadLine());

double hypothenuse = Math.Pow(PremierCote, 2) + Math.Pow(DeuxiemeCote, 2);
double resultat = Math.Sqrt(hypothenuse);

Console.WriteLine($"La longeur de l'hypothenuse est de  : {resultat}" + "cm");
