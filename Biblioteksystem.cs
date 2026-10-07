using System.Security.Cryptography.X509Certificates;

namespace _vningBibliotekssystem_2;

public class Bibliotek
{
     List<Bok> boksamling = new List<Bok>();

    public void LäggTillBok(string titel, string författare, int år)
    {
        Bok nyBok = new Bok(titel, författare, år);
        boksamling.Add(nyBok);
        Console.WriteLine($"Ny bok tillagd Titel: {titel} Författare: {författare} Utgivningsår : {år}");
    }

    public bool LånaBok(string titel)
    {
        foreach (Bok bok in boksamling)
        {
            if (bok.Titel.Equals(titel))
            {
                if (bok.ÄrUtlånad)
                {
                    Console.WriteLine($"Boken är redan utlånad {bok.Titel}");
                    return false;
                }

                bok.ÄrUtlånad = true;
                Console.WriteLine($"Du har lånat {bok.Titel}");
                return true;
            }
        }

        Console.WriteLine($"Boken {titel} finns inte i biblioteket.");
        return false;
    }

    public bool LämnaTillBakaBok(string titel)
    {
        foreach (Bok bok in boksamling)
        {
            if (bok.Titel.Equals(titel))
            {
                if (bok.ÄrUtlånad)
                {
                    bok.ÄrUtlånad = false;
                    Console.WriteLine($"Du har lämnat tillbaka {bok.Titel}");
                    return true;
                }

                Console.WriteLine($"Boken {bok.Titel} är redan återlämnad.");
                return false;
            }
        }

        Console.WriteLine($"Boken {titel} finns inte i biblioteket.");
        return false;
    }

    public void SökEfterTitel(string titel)
    {
        foreach (Bok bok in boksamling)
        {
            if (bok.Titel.Equals(titel))
            {
                
                Console.WriteLine($"Boken {bok.Titel} finns i biblioteket");
                return;
            }
        }

        Console.WriteLine("Boken finns inte i biblioteket.");
    }

    public void VisaAllaBöcker()
    {
        if (boksamling.Count == 0)
        {
            Console.WriteLine("Biblioteket är tomt");
            return;
        }

        foreach (Bok bok in boksamling)
        {
            Console.WriteLine($"{bok.Titel} - {(bok.ÄrUtlånad ? "utlånad" : "tillgänglig")}");
        }
    }
}