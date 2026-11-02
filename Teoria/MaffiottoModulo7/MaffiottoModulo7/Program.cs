namespace MaffiottoModulo7;

class Program
{
    static void Main(string[] args)
    {
        EsercizioContatore();
        EsercizioLogger();
        EsercizioGestioneStudenti();
    }

    /// <summary>
    /// Verifica il funzionamento del contatore e del reset
    /// </summary>
    static void EsercizioContatore()
    {
        Console.WriteLine("--- CONTATORE ---");

        Contatore contatore = Contatore.CreaContatore();
        contatore.Incrementa();
        contatore.Incrementa();

        Console.WriteLine($"Valore del contatore: {contatore.Valore}");

        contatore.Reset();
        Console.WriteLine($"Valore dopo il reset: {contatore.Valore}");
        Console.WriteLine();
    }

    /// <summary>
    /// Usa il Logger singleton per registrare eventi in sequenza
    /// </summary>
    static void EsercizioLogger()
    {
        Console.WriteLine("--- LOGGER SINGLETON ---");

        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("Programma avviato");
        logger2.Log("Contatore verificato");
        logger1.Log("Rubrica studenti pronta");

        Console.WriteLine($"I logger sono la stessa istanza: {ReferenceEquals(logger1, logger2)}");
        Console.WriteLine();
    }

    /// <summary>
    /// Avvia il menu della rubrica studenti
    /// </summary>
    static void EsercizioGestioneStudenti()
    {
        GestioneStudenti gestione = new GestioneStudenti();
        AggiungiDatiIniziali(gestione);

        int scelta;

        do
        {
            StampaMenu();
            scelta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (scelta)
            {
                case 1:
                    AggiungiStudente(gestione);
                    break;
                case 2:
                    RimuoviStudente(gestione);
                    break;
                case 3:
                    CercaStudente(gestione);
                    break;
                case 4:
                    ModificaStudente(gestione);
                    break;
                case 5:
                    gestione.StampaStudenti();
                    break;
                case 0:
                    Logger.Instance.Log("Programma terminato");
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }

            Console.WriteLine();
        }
        while (scelta != 0);
    }

    static void StampaMenu()
    {
        Console.WriteLine("--- GESTIONE STUDENTI ---");
        Console.WriteLine("1. Aggiungi studente");
        Console.WriteLine("2. Rimuovi studente");
        Console.WriteLine("3. Cerca studente");
        Console.WriteLine("4. Modifica studente");
        Console.WriteLine("5. Visualizza studenti");
        Console.WriteLine("0. Esci");
        Console.Write("Scelta: ");
    }

    static void AggiungiDatiIniziali(GestioneStudenti gestione)
    {
        gestione.AggiungiStudente(1, new Studente("Andrea", "Maffiotto", 18, "4A INF"));
        gestione.AggiungiStudente(2, new Studente("Tommaso", "Mandrile", 18, "4A INF"));
        gestione.AggiungiStudente(3, new Studente("Nicolò", "Stoppa", 17, "4A INF"));
    }

    static void AggiungiStudente(GestioneStudenti gestione)
    {
        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine()!;
        Console.Write("Età: ");
        int eta = Convert.ToInt32(Console.ReadLine());
        Console.Write("Classe: ");
        string classe = Console.ReadLine()!;

        Studente studente = new Studente(nome, cognome, eta, classe);

        if (gestione.AggiungiStudente(id, studente))
        {
            Console.WriteLine("Studente aggiunto.");
            Logger.Instance.Log($"Aggiunto lo studente con ID {id}");
        }
        else
        {
            Console.WriteLine("ID già presente.");
        }
    }

    static void RimuoviStudente(GestioneStudenti gestione)
    {
        Console.Write("ID dello studente da rimuovere: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (gestione.RimuoviStudente(id))
        {
            Console.WriteLine("Studente rimosso.");
            Logger.Instance.Log($"Rimosso lo studente con ID {id}");
        }
        else
        {
            Console.WriteLine("Studente non trovato.");
        }
    }

    static void CercaStudente(GestioneStudenti gestione)
    {
        Console.Write("ID dello studente da cercare: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Studente? studente = gestione.CercaStudente(id);

        if (studente != null)
        {
            gestione.StampaStudente(id, studente);
        }
        else
        {
            Console.WriteLine("Studente non trovato.");
        }
    }

    static void ModificaStudente(GestioneStudenti gestione)
    {
        Console.Write("ID dello studente da modificare: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nuovo nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Nuovo cognome: ");
        string cognome = Console.ReadLine()!;
        Console.Write("Nuova età: ");
        int eta = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nuova classe: ");
        string classe = Console.ReadLine()!;

        if (gestione.ModificaStudente(id, nome, cognome, eta, classe))
        {
            Console.WriteLine("Studente modificato.");
            Logger.Instance.Log($"Modificato lo studente con ID {id}");
        }
        else
        {
            Console.WriteLine("Studente non trovato.");
        }
    }
}
