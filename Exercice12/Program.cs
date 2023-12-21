Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...?");

Console.Write("Entrez l'âge de votre enfant : ");
int age = int.Parse(Console.ReadLine());

Console.Write("Votre enfant est dans la catégorie : ");

if (age < 3)
{
    Console.WriteLine("Votre enfant est trop jeune");
}
else if (age <= 6)
{
    Console.WriteLine("Baby");
}
else if ( age <= 8)
{
    Console.WriteLine(" Poussin");
}
else if (age <= 10)
{
    Console.WriteLine(" Pupille");
}
else if ( age <= 12)
{
    Console.WriteLine(" Minime");
}
else if (age <= 13)
{
    Console.WriteLine(" Cadet");
}
else if (age >= 18)
{
    Console.WriteLine("Votre enfant n'est plus un enfant");
}
else
{
    Console.WriteLine("Votre enfant n'est pas dans une catégorie définie");
}
