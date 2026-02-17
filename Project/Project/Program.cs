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

     // i < (5) , 5 = antalet gånger den slår.
        for (int i = 0; i < 5; i++)
        {
            Random slumpNum = new Random();

         // Next(1),(7) , 1 och 7 är tärningen. Den går 1-7 = 6 sidor.
            int nummer = slumpNum.Next(1,7);
            Console.WriteLine("Du slåg: " + nummer);
            
         // nummer == (5) , 5 = nummret man samlar.
            if (nummer == 5)
            {
                antal++;
                total++;
            }

        }

        Console.WriteLine("Antalet femmor du slog: " + antal);

        Console.WriteLine("Vill du fortsätta? ja eller nej?");
        svar = Console.ReadLine();
        Console.WriteLine();

        if (svar == "nej")
        {
            Console.WriteLine();
            Console.WriteLine("okej.. ):");
        }

        while (svar == "ja")
        {

            for (int i = 0; i < 5; i++)
            {
                Random slumpNum = new Random();
                int nummer = slumpNum.Next(1, 7);
                Console.WriteLine("Du slåg: " + nummer);

                if (nummer == 5)
                {
                    antal++;
                    total++;

                 //total > (5) , 5 = Max antal man kan samla på.
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
            svar = Console.ReadLine();
            Console.WriteLine();

            if (svar == "nej")
            {
            
             //total == (5) , 5 = Det antalet man slutar på för att vinna!
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