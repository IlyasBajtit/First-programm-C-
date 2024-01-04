
// Tuple
(double, double, double,double) Operation(double a, double b)
{
    double somme = a + b;
    double diff = a - b;
    double quotient = a / b;
    double produit = a * b;
    return(somme, diff, quotient, produit);
}

(double a, double b, double c, double d) = Operation(2, 5);

Console.WriteLine($"La somme est {a}, La difference est {b}, Le quotient est {c}, Le produit est {d} ");