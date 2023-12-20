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


