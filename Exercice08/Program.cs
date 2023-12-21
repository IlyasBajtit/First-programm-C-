
Console.Write("Entrez le prix HT de l'objet (en Euros): ");
double PrixHt = double.Parse(Console.ReadLine());

Console.Write("Entrez le taux de TVA (en %): ");
double TauxTva = double.Parse(Console.ReadLine());

double mtTva = PrixHt * TauxTva / 100;
double Prixobj = PrixHt + TauxTva;

Console.WriteLine($"Le montatnt de la T.V.A est de : {mtTva}" +  "Euros");
Console.WriteLine($"Le prix TTC de l'objet est de : {Prixobj}" + "Euros");


/*Correction:

//var prixHT = double.Parse(Console.ReadLine());
//var tva = double.Parse(Console.ReadLine());
//var taxe = (prixHT * tva) / 100;
//var prixTotal = prixHT + taxe;


Console.WriteLine("Entrez le prix HT (en euros) :");
float prixHT = float.Parse(Console.ReadLine());
Console.WriteLine("Entrez le taux de TVA (en %) :");
float txTVA = float.Parse(Console.ReadLine()); // / 100;
float montantTVA = prixHT * txTVA / 100;
Console.WriteLine($"Le montant de la TVA est de {montantTVA} euros");
Console.WriteLine($"Le prix TTC est de {prixHT + montantTVA} euros");
*/