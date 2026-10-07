namespace _vningBibliotekssystem_2;

public class Bok
{   
    //Attributer
    public string Titel { get; set; } = string.Empty;
    public string Författare { get; set; } = string.Empty;
    public int År { get; set; }
    public bool ÄrUtlånad { get; set; }

        //Constructor
    public Bok(string titel, string författare, int år, bool ärUtlånad = false)
    {
        Titel = titel;
        Författare = författare;
        År = år;
        ÄrUtlånad = ärUtlånad;
    }
}
