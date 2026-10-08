namespace Andrea_Maffiotto_Modulo_3;

class Program
{
    static void Main(string[] args)
    {
        // Esercizio 3.1
        Contatore c1 = new Contatore();
        Contatore c2 = new Contatore();
        c1.Conteggio = 67;
        c2.Conteggio = 90;

        Console.WriteLine($"C1: {c1.Conteggio} C2: {c2.Conteggio} Totale istanza: {Contatore.TotaleIstanza}");
        // Esercizio 3.2
        Console.WriteLine($"Valore visualizzato prima dell'istanziazione: \"{Configurazione.Impostazioni}\"");
        int a = 6;
        int b = 8;
        int c = MathUtility.Somma(a, b);
        double d = MathUtility.Media(c, b);
        Console.WriteLine($"Somma tra 6 e 8: {c}; media di 14 e 8: {d}");
    }
}