 //Bonus version tableau

for (int multi = 1; multi <= 10; multi++)
    Console.Write($"{multi}\t");
Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine(string.Concat(Enumerable.Repeat("-", 60)));

for (int table = 1; table <= 10; table++)
{
    for (int multi = 1; multi <= 10; multi++)
        Console.Write($"{multi*table}\t");
    Console.WriteLine();
}