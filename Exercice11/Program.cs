

Console.WriteLine("--- Le nombre est-il divisible par ...? ---");

Console.Write("Entrez un chiffre/nombre entier : ");
int nbentier = int.Parse(Console.ReadLine());

Console.Write("Entrez un chiffre/nombre diviseur : ");
int nbdiviseur = int.Parse(Console.ReadLine());


if (nbentier % nbdiviseur == 0)
{
     Console.Write($"Le chiffre/nombre est divisible par {nbdiviseur} ");
}
else
{
    Console.WriteLine($"Le chiffre/nombre n'est pas divisible par {nbdiviseur}");
}
