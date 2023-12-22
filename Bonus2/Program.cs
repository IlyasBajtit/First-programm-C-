// En arc en ciel

List<ConsoleColor> colors = new List<ConsoleColor>()
{
    ConsoleColor.Red,
    ConsoleColor.Magenta,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.Green,
    ConsoleColor.Yellow
};

string sousBarre = string.Concat(Enumerable.Repeat("-", largeurCol));
string barre = "+" + string.Concat(Enumerable.Repeat(sousBarre + "+", largeurTables));

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(barre);

for (int i = 1; i <= nbTables; i++)
{
    Console.ForegroundColor = colors[i % colors.Count];
    Console.Write("|");
    for (int j = 1; j <= largeurTables; j++)
    {
        Console.ForegroundColor = colors[(i + j) % colors.Count];
        Console.Write($"{i * j,largeurCol}|");
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(barre);
}