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