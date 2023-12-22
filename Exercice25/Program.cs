double notemax = 0;
double notemin = 20;
double notemoy = 0;

Console.WriteLine("--- Gestion des notes ---");
Console.WriteLine("Veuillez saisir 5 notes : ");


for (int i = 0; i < 5; i++)
{
    Console.Write($"Merci de saisir la note {i + 1} (sur /20) : ");
    double noteTmp = Convert.ToDouble(Console.ReadLine());

    if (noteTmp > notemax)
    {
        notemax = noteTmp;
    }

    if (noteTmp < notemin)
    {
        notemin = noteTmp;
    }

    notemoy += noteTmp;

}
notemoy /= 5; 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est {notemax}/20");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {notemin}/20");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est {notemoy}/20");


/*Correction:

Console.WriteLine("--- Gestion des notes ---\n\n");
Console.WriteLine("Veuillez saisir 5 notes : \n\n");
double max = 0, min = 20, somme = 0, moyenne;

for (int i = 1; i <= 5; i++)
{
    Console.Write("\t - Merci de saisir la note " + i + "(sur /20) :");
    double note;
    while (!double.TryParse(Console.ReadLine(), out note) || note < 0 || note > 20)
        Console.WriteLine("Saisie invalide ! Réésayer :");
    if (note > max)
        max = note;
    if (note < min)
        min = note;
    somme += note;
}

moyenne = somme / 5;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nla meilleure note est " + max + "/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("la moins bonne note est " + min + "/20");
//Console.ForegroundColor = ConsoleColor.Gray;
Console.ResetColor();
Console.WriteLine("la moyenne des note est " + moyenne + "/20");*/