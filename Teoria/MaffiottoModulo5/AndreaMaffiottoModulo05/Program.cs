namespace AndreaMaffiottoModulo05;

class Program
{
    static void Main(string[] args)
    {
        List<Studente> studenti = new List<Studente>();
        Dictionary<int, Studente> rubrica = new Dictionary<int, Studente>();
        Queue<string> listaAttesa = new Queue<string>();
        Stack<string> cancellazioni = new Stack<string>();
        Dictionary<int, int> voti = new Dictionary<int, int>();

        AggiungiDatiIniziali(studenti, rubrica, voti);

        int scelta;
        
        do
        {
            StampaMenu();
            scelta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (scelta)
            {
                case 1:
                    AggiungiStudente(studenti, rubrica);
                    break;

                case 2:
                    RimuoviStudente(studenti, rubrica, cancellazioni, voti);
                    break;

                case 3:
                    CercaStudente(rubrica);
                    break;

                case 4:
                    StampaStudenti(studenti);
                    break;

                case 5:
                    OrdinaPerCognome(studenti);
                    break;

                case 6:
                    FiltraPerEta(studenti);
                    break;

                case 7:
                    AggiungiInAttesa(listaAttesa);
                    break;

                case 8:
                    GestisciProssimoInAttesa(listaAttesa);
                    break;

                case 9:
                    AnnullaCancellazione(studenti, rubrica, cancellazioni, voti);
                    break;

                case 10:
                    AggiungiAggiornaVoto(rubrica, voti);
                    break;

                case 11:
                    StampaStatisticheVoti(rubrica, voti);
                    break;

                case 0:
                    Console.WriteLine("Programma terminato.");
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
        Console.WriteLine("--- RUBRICA STUDENTI ---");
        Console.WriteLine("1. Aggiungi studente");
        Console.WriteLine("2. Rimuovi studente");
        Console.WriteLine("3. Cerca studente per ID");
        Console.WriteLine("4. Stampa tutti gli studenti");
        Console.WriteLine("5. Ordina per cognome");
        Console.WriteLine("6. Filtra per età");
        Console.WriteLine("7. Aggiungi alla lista d'attesa");
        Console.WriteLine("8. Gestisci il prossimo in attesa");
        Console.WriteLine("9. Annulla ultima cancellazione");
        Console.WriteLine("10. Aggiungi o aggiorna voto");
        Console.WriteLine("11. Mostra statistiche voti");
        Console.WriteLine("0. Esci");
        Console.Write("Scelta: ");
    }

    static void AggiungiDatiIniziali(List<Studente> studenti, Dictionary<int, Studente> rubrica,
        Dictionary<int, int> voti)
    {
        Studente studente1 = new Studente("Andrea", "Maffiotto", 18);
        Studente studente2 = new Studente("Tommaso", "Mandrile", 18);
        Studente studente3 = new Studente("Erdi", "Kasneci", 19);

        studenti.Add(studente1);
        studenti.Add(studente2);
        studenti.Add(studente3);

        rubrica.Add(1, studente1);
        rubrica.Add(2, studente2);
        rubrica.Add(3, studente3);

        voti.Add(1, 8);
        voti.Add(2, 7);
        voti.Add(3, 9);
    }

    static void AggiungiStudente(List<Studente> studenti, Dictionary<int, Studente> rubrica)
    {
        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine() ?? "";
        Console.Write("Età: ");
        int eta = Convert.ToInt32(Console.ReadLine());

        Studente studente = new Studente(nome, cognome, eta);
        studenti.Add(studente);
        rubrica.Add(id, studente);

        Console.WriteLine("Studente aggiunto.");
    }

    static void RimuoviStudente(List<Studente> studenti, Dictionary<int, Studente> rubrica,
        Stack<string> cancellazioni, Dictionary<int, int> voti)
    {
        Console.Write("ID dello studente da rimuovere: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Studente studente = rubrica[id];
        int voto = -1;

        if (voti.ContainsKey(id))
        {
            voto = voti[id];
        }
        
        string datiCancellazione = $"{id}|{studente.Nome}|{studente.Cognome}|{studente.Età}|{voto}";
        cancellazioni.Push(datiCancellazione);

        studenti.Remove(studente);
        rubrica.Remove(id);
        voti.Remove(id);

        Console.WriteLine("Studente rimosso.");
    }

    static void CercaStudente(Dictionary<int, Studente> rubrica)
    {
        Console.Write("ID dello studente da cercare: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Studente studente = rubrica[id];
        StampaStudente(id, studente);
    }

    static void StampaStudenti(List<Studente> studenti)
    {
        for (int i = 0; i < studenti.Count; i++)
        {
            Studente studente = studenti[i];
            Console.WriteLine($"{studente.Nome} {studente.Cognome}, {studente.Età} anni");
        }
    }
    static int ConfrontaPerCognome(Studente studente1, Studente studente2)
    {
        return studente1.Cognome.CompareTo(studente2.Cognome);
    }

    static void OrdinaPerCognome(List<Studente> studenti)
    {
        studenti.Sort(ConfrontaPerCognome);
        Console.WriteLine("Studenti ordinati per cognome:");
        StampaStudenti(studenti);
    }

    static void FiltraPerEta(List<Studente> studenti)
    {
        Console.Write("Età minima: ");
        int etaMinima = Convert.ToInt32(Console.ReadLine());
        List<Studente> studentiFiltrati = studenti.FindAll(studente => studente.Età > etaMinima);

        Console.WriteLine($"Studenti con età superiore a {etaMinima}:");
        StampaStudenti(studentiFiltrati);
    }

    static void AggiungiInAttesa(Queue<string> listaAttesa)
    {
        Console.Write("Nome da aggiungere alla lista d'attesa: ");
        string nome = Console.ReadLine() ?? "";

        listaAttesa.Enqueue(nome);
        Console.WriteLine($"{nome} aggiunto alla lista d'attesa.");
    }

    static void GestisciProssimoInAttesa(Queue<string> listaAttesa)
    {
        if (listaAttesa.Count > 0)
        {
            Console.WriteLine($"Prossimo in attesa: {listaAttesa.Peek()}");
            Console.WriteLine($"Persona gestita: {listaAttesa.Dequeue()}");
        }
        else
        {
            Console.WriteLine("La lista d'attesa è vuota.");
        }
    }

    static void AnnullaCancellazione(List<Studente> studenti, Dictionary<int, Studente> rubrica,
        Stack<string> cancellazioni, Dictionary<int, int> voti)
    {
        if (cancellazioni.Count > 0)
        {
            string datiCancellazione = cancellazioni.Pop();
            string[] dati = datiCancellazione.Split('|');

            int id = Convert.ToInt32(dati[0]);
            string nome = dati[1];
            string cognome = dati[2];
            int eta = Convert.ToInt32(dati[3]);
            int voto = Convert.ToInt32(dati[4]);

            Studente studente = new Studente(nome, cognome, eta);
            studenti.Add(studente);
            rubrica.Add(id, studente);

            if (voto != -1)
            {
                voti.Add(id, voto);
            }

            Console.WriteLine("Ultima cancellazione annullata.");
        }
        else
        {
            Console.WriteLine("Non ci sono cancellazioni da annullare.");
        }
    }
    
    static void AggiungiAggiornaVoto(Dictionary<int, Studente> rubrica, Dictionary<int, int> voti)
    {
        Console.Write("ID dello studente: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Voto: ");
        int voto = Convert.ToInt32(Console.ReadLine());

        Studente studente = rubrica[id];
        voti[id] = voto;

        Console.WriteLine($"Voto di {studente.Nome} {studente.Cognome} salvato.");
    }
    
    static double CalcolaMedia(Dictionary<int, int> voti)
    {
        int somma = 0;

        foreach (int voto in voti.Values)
        {
            somma += voto;
        }

        return (double)somma / voti.Count;
    }
    
    static int TrovaIdVotoMassimo(Dictionary<int, int> voti)
    {
        int idMassimo = -1;
        int votoMassimo = -1;

        foreach (KeyValuePair<int, int> elemento in voti)
        {
            if (elemento.Value > votoMassimo)
            {
                votoMassimo = elemento.Value;
                idMassimo = elemento.Key;
            }
        }

        return idMassimo;
    }

    static void StampaStatisticheVoti(Dictionary<int, Studente> rubrica, Dictionary<int, int> voti)
    {
        if (voti.Count > 0)
        {
            double media = CalcolaMedia(voti);
            int idMassimo = TrovaIdVotoMassimo(voti);
            Studente studenteMigliore = rubrica[idMassimo];

            Console.WriteLine($"Media dei voti: {media:F2}");
            Console.WriteLine($"Voto massimo: {studenteMigliore.Nome} {studenteMigliore.Cognome}, {voti[idMassimo]}");
        }
        else
        {
            Console.WriteLine("Non sono presenti voti.");
        }
    }

    static void StampaStudente(int id, Studente studente)
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nome: {studente.Nome}");
        Console.WriteLine($"Cognome: {studente.Cognome}");
        Console.WriteLine($"Età: {studente.Età}");
    }
}
