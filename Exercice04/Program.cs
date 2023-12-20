Console.Write("Veuillez saisir votre prénom: ");
string nom = Console.ReadLine();
Console.Write("Veuillez saisir votre nom: ");
string prenom = Console.ReadLine();
Console.Write("Veuillez saisir votre age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Bonjour {nom} {prenom}, vous avez {age} ans");