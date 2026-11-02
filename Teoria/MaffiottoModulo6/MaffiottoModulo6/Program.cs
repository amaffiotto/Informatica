namespace MaffiottoModulo6;

class Program
{
    static void Main(string[] args)
    {
        Esercizio61();
        Esercizio62();
        EsercizioA();
        EsercizioB();
        EsercizioC();
    }

    static void Esercizio61()
    {
        Console.WriteLine("\nESERCIZIO 6.1");

        List<Studente> studenti = CreaListaStudenti();

        Studente studenteDaRimuovere = studenti[3];
        studenti.Remove(studenteDaRimuovere);
        Console.WriteLine($"Rimosso: {studenteDaRimuovere.Nome} {studenteDaRimuovere.Cognome}");

        string nomeCercato = "Andrea";
        Studente? studenteTrovato = studenti.Find(studente => studente.Nome.ToLower() == nomeCercato.ToLower());

        if (studenteTrovato != null)
        {
            Console.WriteLine("Studente trovato:");
            StampaStudente(studenteTrovato);
        }
        else
        {
            Console.WriteLine("Studente non trovato");
        }
    }

    static void Esercizio62()
    {
        Console.WriteLine("\nESERCIZIO 6.2");

        Dictionary<int, Studente> rubrica = new Dictionary<int, Studente>();

        rubrica.Add(1, new Studente("Andrea", "Maffiotto", 18));
        rubrica.Add(2, new Studente("Nicolò", "Stoppa", 17));
        rubrica.Add(3, new Studente("Tommaso", "Mandrile", 18));

        int idCercato = 2;
        Studente? studenteTrovato;

        if (rubrica.TryGetValue(idCercato, out studenteTrovato))
        {
            Console.WriteLine($"Studente con ID {idCercato}:");
            StampaStudente(studenteTrovato);
        }
        else
        {
            Console.WriteLine("Studente non trovato");
        }

        int idDaRimuovere = 3;

        if (rubrica.Remove(idDaRimuovere))
        {
            Console.WriteLine($"Studente con ID {idDaRimuovere} rimosso");
        }
        else
        {
            Console.WriteLine("Studente non trovato");
        }
    }

    static void EsercizioA()
    {
        Console.WriteLine("\nESERCIZIO A - RUBRICA STUDENTI");

        List<Studente> studenti = new List<Studente>();
        Dictionary<int, Studente> rubrica = new Dictionary<int, Studente>();
        int scelta;
        
        do
        {
            Console.WriteLine("\n1. Aggiungi studente");
            Console.WriteLine("2. Rimuovi studente");
            Console.WriteLine("3. Cerca studente");
            Console.WriteLine("4. Visualizza studenti");
            Console.WriteLine("0. Termina");
            Console.Write("Scelta: ");
            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    AggiungiStudente(studenti, rubrica);
                    break;
                case 2:
                    RimuoviStudente(studenti, rubrica);
                    break;
                case 3:
                    CercaStudente(rubrica);
                    break;
                case 4:
                    StampaRubrica(rubrica);
                    break;
                case 0:
                    Console.WriteLine("Rubrica chiusa");
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        } while (scelta != 0);
    }

    static void AggiungiStudente(List<Studente> studenti, Dictionary<int, Studente> rubrica)
    {
        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine()!;
        Console.Write("Età: ");
        int eta = Convert.ToInt32(Console.ReadLine());

        Studente nuovoStudente = new Studente(nome, cognome, eta);
        
        studenti.Add(nuovoStudente);
        rubrica.Add(id, nuovoStudente);

        Console.WriteLine("Studente aggiunto");
    }

    static void RimuoviStudente(List<Studente> studenti, Dictionary<int, Studente> rubrica)
    {
        Console.Write("ID dello studente da rimuovere: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Studente? studenteDaRimuovere;

        if (rubrica.TryGetValue(id, out studenteDaRimuovere))
        {
            studenti.Remove(studenteDaRimuovere);
            rubrica.Remove(id);
            Console.WriteLine("Studente rimosso");
        }
        else
        {
            Console.WriteLine("Studente non trovato");
        }
    }

    static void CercaStudente(Dictionary<int, Studente> rubrica)
    {
        Console.Write("ID dello studente da cercare: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Studente? studenteTrovato;

        if (rubrica.TryGetValue(id, out studenteTrovato))
        {
            StampaStudente(studenteTrovato);
        }
        else
        {
            Console.WriteLine("Studente non trovato");
        }
    }

    static void StampaRubrica(Dictionary<int, Studente> rubrica)
    {
        foreach (KeyValuePair<int, Studente> elemento in rubrica)
        {
            Console.WriteLine($"ID: {elemento.Key}");
            StampaStudente(elemento.Value);
        }
    }

    static void EsercizioB()
    {
        Console.WriteLine("\nESERCIZIO B - ORDINAMENTO E FILTRAGGIO");

        List<Studente> studenti = CreaListaStudenti();
        OrdinaPerCognome(studenti);

        Console.WriteLine("Studenti ordinati per cognome:");
        StampaLista(studenti);

        int etaMinima = 17;
        List<Studente> studentiFiltrati = studenti.FindAll(studente => studente.Età > etaMinima);

        Console.WriteLine($"\nStudenti con età superiore a {etaMinima}:");
        StampaLista(studentiFiltrati);
    }

    static void OrdinaPerCognome(List<Studente> studenti)
    {
        for (int i = 0; i < studenti.Count - 1; i++)
        {
            for (int j = i + 1; j < studenti.Count; j++)
            {
                if (studenti[i].Cognome.CompareTo(studenti[j].Cognome) > 0)
                {
                    Studente temporaneo = studenti[i];
                    studenti[i] = studenti[j];
                    studenti[j] = temporaneo;
                }
            }
        }
    }

    static void EsercizioC()
    {
        Console.WriteLine("\nESERCIZIO C - DICTIONARY DEI VOTI");

        Dictionary<int, int> voti = new Dictionary<int, int>();
        voti.Add(1, 7);
        voti.Add(2, 8);
        voti.Add(3, 6);
        voti.Add(4, 9);

        AggiornaVoto(voti, 3, 8);

        double media = CalcolaMedia(voti);
        Console.WriteLine($"Media dei voti: {media:F2}");

        int idVotoMassimo = TrovaIdVotoMassimo(voti);
        Console.WriteLine($"Lo studente con ID {idVotoMassimo} ha il voto massimo: {voti[idVotoMassimo]}");
    }

    static void AggiornaVoto(Dictionary<int, int> voti, int id, int nuovoVoto)
    {
        voti[id] = nuovoVoto;
        Console.WriteLine($"Voto dello studente con ID {id} aggiornato a {nuovoVoto}");
    }

    static double CalcolaMedia(Dictionary<int, int> voti)
    {
        int somma = 0;

        foreach (KeyValuePair<int, int> elemento in voti)
        {
            somma = somma + elemento.Value;
        }

        double media = (double)somma / voti.Count;
        return media;
    }

    static int TrovaIdVotoMassimo(Dictionary<int, int> voti)
    {
        int idMassimo = 0;
        int votoMassimo = 0;

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

    static List<Studente> CreaListaStudenti()
    {
        List<Studente> studenti = new List<Studente>();

        studenti.Add(new Studente("Andrea", "Maffiotto", 18));
        studenti.Add(new Studente("Andrea", "Zefi", 18));
        studenti.Add(new Studente("Nicolò", "Stoppa", 17));
        studenti.Add(new Studente("Tommaso", "Mandrile", 18));
        studenti.Add(new Studente("Frenk", "Zhala", 19));

        return studenti;
    }

    static void StampaLista(List<Studente> studenti)
    {
        for (int i = 0; i < studenti.Count; i++)
        {
            StampaStudente(studenti[i]);
        }
    }

    static void StampaStudente(Studente studente)
    {
        Console.WriteLine($"Nome: {studente.Nome}, Cognome: {studente.Cognome}, Età: {studente.Età}");
    }
}
