//CARRE
/*Console.Write("Entrez la longeur d'un coté du carré (en cm): ");
double longeurCote = double.Parse(Console.ReadLine());

double perimetre = longeurCote * 4;
double aire = longeurCote * longeurCote;

Console.WriteLine("Le périmètre du carré est de :" + perimetre + " " + "cm");
Console.WriteLine("L'aire du carré est de :" + aire + " " + "cm2");*/


// RECTANGLE

Console.Write("Entrez la longeur d'un coté du rectangle (en cm): ");
double longeurRectangle = double.Parse(Console.ReadLine());

Console.Write("Entrez la largeur d'un coté du rectangle (en cm): ");
double largeurRectangle = double.Parse(Console.ReadLine());

double perimetreRectangle = (longeurRectangle + largeurRectangle) * 2;
double aire = longeurRectangle * largeurRectangle;

Console.WriteLine("Le périmètre du rectangle est de :" + perimetreRectangle + " " + "cm");
Console.WriteLine("L'aire du  rectangle de :" + aire + " " + "cm2");



/*Correction:

//float cote= float.Parse(Console.ReadLine());
//float perimetre = cote * 4;
////float aire = cote * cote;
//double aire = Math.Pow(cote,2);


Console.Write("Entrez la longueur d'un côté du carré (en cm) : ");
float cote = Convert.ToSingle(Console.ReadLine()); //float cote = float.Parse(Console.ReadLine());

Console.WriteLine("Périmètre :" + cote * 4);
Console.WriteLine("Aire :" + cote * cote);
Console.WriteLine("Aire :" + Math.Pow(cote, 2));


Console.Write("Entrez la longueur d'un rectangle (en cm) : ");
decimal longueur = Convert.ToDecimal(Console.ReadLine());
Console.Write("Entrez la largeur d'un rectangle (en cm) : ");
decimal largeur = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Périmètre :" + (longueur + largeur) * 2);
Console.WriteLine("Aire :" + longueur * largeur);*/



