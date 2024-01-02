﻿
    {
        Console.WriteLine("Entrez la hauteur du sapin de Noël :");
        int hauteurSapin;
        if (!int.TryParse(Console.ReadLine(), out hauteurSapin) || hauteurSapin < 1)
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif pour la hauteur du sapin.");
            return;
        }

        Console.WriteLine("Entrez la hauteur du tronc du sapin :");
        int hauteurTronc;
        if (!int.TryParse(Console.ReadLine(), out hauteurTronc) || hauteurTronc < 1)
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif pour la hauteur du tronc.");
            return;
        }

        for (int i = 0; i < hauteurSapin; i++)
        {
            for (int j = 0; j < hauteurSapin - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (2 * i) + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < hauteurTronc; i++)
        {
            for (int j = 1; j < hauteurSapin - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("| |");
        }
    }

// Triangle : 
