
Console.Write("Entrez le prix HT de l'objet (en Euros): ");
double PrixHt = double.Parse(Console.ReadLine());

Console.Write("Entrez le taux de TVA (en %): ");
double TauxTva = double.Parse(Console.ReadLine());

double mtTva = PrixHt * TauxTva / 100;
double Prixobj = PrixHt + TauxTva;

Console.WriteLine($"Le montatnt de la T.V.A est de : {mtTva}" +  "Euros");
Console.WriteLine($"Le prix TTC de l'objet est de : {Prixobj}" + "Euros");


