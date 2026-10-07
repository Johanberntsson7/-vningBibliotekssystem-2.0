using System;
using System.Collections.Generic;
using System.Linq;

namespace _vningBibliotekssystem_2._0;

class Program
{
    static void Main(string[] args)
    {
        Bibliotek bibliotek = new Bibliotek();
        bool kör = true;

        while (kör)
        {
            Console.WriteLine("1. Lägg till en bok");
            Console.WriteLine("2. Låna en bok");
            Console.WriteLine("3. Lämna tillbaka en bok");
            Console.WriteLine("4. Sök efter en titel eller författare");
            Console.WriteLine("5. Visa alla tillgängliga böcker");
            Console.WriteLine("6. Avsluta");

            Console.Write("Välj ett alternativ: ");
            int.TryParse(Console.ReadLine(), out int val);

            switch (val)
            {
                case 1:
                    Console.WriteLine("Titel:");
                    string boktitel = Console.ReadLine()!;
                    Console.WriteLine("Författare:");
                    string författare = Console.ReadLine()!;
                    Console.WriteLine("Utgivningsår:");
                    int bokår = int.Parse(Console.ReadLine()!);
                    bibliotek.LäggTillBok(titel: boktitel, författare: författare, år: bokår);
                    break;

                case 2:
                    Console.WriteLine("Vilken bok vill du låna?");
                    string titel = Console.ReadLine()!;
                    bibliotek.LånaBok(titel);
                    break;

                case 3:
                    Console.WriteLine("Vilken bok vill du lämna tillbaka?");
                    string returTitel = Console.ReadLine()!;
                    bibliotek.LämnaTillBakaBok(returTitel);
                    break;

                case 4:
                    Console.WriteLine("Sök efter titel:");
                    string sökTitel = Console.ReadLine()!;
                    bibliotek.SökEfterTitel(sökTitel);
                    break;

                case 5:
                    Console.WriteLine("Visa alla böcker, tillgängliga som utlånade");
                    bibliotek.VisaAllaBöcker();
                    break;

                case 6:
                    kör = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

        
      
        

