Console.WriteLine("--- Les tables de multiplication ---");



for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("\t Table de " + i);

    for (int j = 1; j <= 10; j++)
        Console.WriteLine("\t " + i + " x " + j + " = " + (i * j));


}


/*Correction:

for (int table = 1; table <= 10; table++)
{
    Console.WriteLine("Table de " + table);
    for (int multi = 1; multi <= 10; multi++)
      Console.WriteLine($"\t {table} x {multi} = {table * multi}");
}

*/
