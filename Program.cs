namespace AS2627._3F.UlianaDavide.IRPEF;

class Program
{
    static void Main(string[] args)
    {
        double lordo, tax1, tax2 = 0, tax3 = 0, tot;    
        Console.Write("Inserisci il reddito: ");
        lordo = Convert.ToDouble(Console.ReadLine());
        if (lordo <= 28000)
        {
            tax1 = lordo * 0.23;
        }
        else if (lordo <= 50000)
        {
            tax1 = 6440; // primo scaglione
            tax2 = (lordo - 28000) * 0.33; // quello che rimane tassato al 33% (secondo scaglione)
        }
        else // se > 50000
        {
            tax1 = 6440; // primo scaglione
            tax2 = 7260; // secondo scaglione
            tax3 = (lordo - 50000) * 0.43; // rimanente tassato al 43% (terzo scaglione)
        }
        tot = tax1 + tax2 + tax3;
        Console.WriteLine($"IRPEF calcolato al 23%: {tax1}€, IRPEF calcolato al 33%: {tax2}€, IRPEF calcolato al 43%: {tax3}€");
        Console.WriteLine($"IRPEF totale: {tot}€");
        Console.WriteLine($"Reddito netto: {lordo - tot}€");
    }
}
