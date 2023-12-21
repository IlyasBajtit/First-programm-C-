Console.WriteLine("--- Quelle boisson souhaitez-vous?");

Console.Write("Liste des boissons disponibles : ");
Console.Write("\t1)Eau plate");
Console.Write("\t2)Eau gazeuse");
Console.Write("\t3)Coca-Cola");
Console.Write("\t4)Fanta");
Console.Write("\t5)Sprite");
Console.Write("\t6Orangina)");
Console.Write("\t7)7Up");
Console.WriteLine("Faite votre choix (1 a 7) : ");

string choice  = Console.ReadLine();
string boisson = "";

switch (choice)
{
    case "1":
        boisson = "Eau plate";
        break;

    case "2":
        boisson = "Eau gazeuse";
        break;

    case "3":
        boisson = "Coca-Cola";
        break;

    case "4":
        boisson = "Fanta";
        break;

    case "5":
        boisson = "Sprite";
        break;
    case "6":
        boisson = "Orangina";
        break;
    case "7":
        boisson = "7Up";
        break;

    default:
        Console.WriteLine("Mauvais choix !");
        break;
}

