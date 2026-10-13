namespace Andrea_Maffiotto_Modulo_4;

class Program
{
    static void Main(string[] args)
    {
        // Esercizio 4.1 ed esercizio A
        Contatore contatore1 = Contatore.CreaContatore();
        Contatore contatore2 = Contatore.CreaContatore();

        contatore1.Incrementa();
        contatore1.Incrementa();
        contatore2.Incrementa();

        Console.WriteLine($"Valore contatore 1: {contatore1.Valore}");
        Console.WriteLine($"Valore contatore 2: {contatore2.Valore}");
        Console.WriteLine($"Totale istanze create: {Contatore.TotaleIstanze}");

        Contatore.ResetTotale();
        Console.WriteLine($"Totale dopo il reset: {Contatore.TotaleIstanze}");

        Contatore contatore3 = Contatore.CreaContatore();
        Console.WriteLine($"Totale dopo una nuova istanza: {Contatore.TotaleIstanze}");

        // Esercizio 4.2
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("Prima operazione completata");
        logger2.Log("Seconda operazione completata");

        Console.WriteLine($"I logger sono la stessa istanza: {ReferenceEquals(logger1, logger2)}");

        // Esercizio B
        Configurazione configurazione1 = Configurazione.Instance;
        configurazione1.Ambiente = "Produzione";
        configurazione1.Versione = "1.1";

        Configurazione configurazione2 = Configurazione.Instance;

        Console.WriteLine($"Ambiente: {configurazione2.Ambiente}");
        Console.WriteLine($"Versione: {configurazione2.Versione}");
        Console.WriteLine($"Le configurazioni sono la stessa istanza: {ReferenceEquals(configurazione1, configurazione2)}");
    }
}
