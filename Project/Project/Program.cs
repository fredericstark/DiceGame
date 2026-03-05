using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;

class Program
{
    static void Main()
    {
        Random slumpFem = new Random();
        int antal = 0;
        int total = 0;

        string svar;

        Console.WriteLine("Hur många tärningar vill du slå? (1 till 10)");
        int tärningsSlag =int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (tärningsSlag > 10)
        {
            tärningsSlag = 10;
            Console.WriteLine();
            Console.WriteLine("Tyvärr är 10 max, så vi kör på 10!");
        }

        for (int i = 0; i < tärningsSlag; i++)
        {
            Random slumpNum = new Random();

            int nummer = slumpNum.Next(1,7);
            Console.WriteLine("Du slåg: " + nummer);
            
         
            if (nummer == 5)
            {
                antal++;
                total++;
            }

        }

        Console.WriteLine("Antalet femmor du slog: " + antal);

        Console.WriteLine("Vill du fortsätta? ja eller nej?");
        svar = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (svar == "nej")
        {
            Console.WriteLine();
            Console.WriteLine("okej.. ):");
        }

        while (svar == "ja")
        {
         
            antal = antal;

            Console.WriteLine("Hur många tärningar vill du slå? (1 till 10)");
            tärningsSlag = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (tärningsSlag > 10)
            {
                tärningsSlag = 10;
                Console.WriteLine();
                Console.WriteLine("Tyvärr är 10 max, så vi kör på 10!");
            }

            for (int i = 0; i < tärningsSlag; i++)
            {
                Random slumpNum = new Random();
                int nummer = slumpNum.Next(1, 7);
                Console.WriteLine("Du slåg: " + nummer);

                if (nummer == 5)
                {
                    antal++;
                    total++;

                 
                    if (total > 5)
                    {
                        Console.WriteLine("...");
                        Console.WriteLine("Du har FÖRMYCKET femmor.. ):");
                        Console.WriteLine("Antalet femmor: " + total + " (Greedy)");
                        return;
                    }
                    
                }

            }
            

            Console.WriteLine("Antalet femmor du slog: " + antal);
            Console.WriteLine("Vill du avsluta? ja eller nej?");
            svar = Console.ReadLine().ToLower();
            Console.WriteLine();
            
            if (svar == "nej")
            {
            
             
                if (total == 5)
                {
                    Console.WriteLine("DU HAR PRECIS 5!! (:");
                }
                else
                {
                    Console.WriteLine("Wow du har: " + total + " femmor!");
                }
                
            }

        }
    }
}