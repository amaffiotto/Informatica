namespace MaffiottoModulo7;

/*
+------------------------------------------------+
|              GestioneStudenti                 |
+------------------------------------------------+
| - studenti: List<Studente>                    |
| - rubrica: Dictionary<int, Studente>          |
+------------------------------------------------+
| + GestioneStudenti()                          |
| + AggiungiStudente(id, studente): bool        |
| + RimuoviStudente(id): bool                   |
| + CercaStudente(id): Studente                 |
| + ModificaStudente(id, nome, cognome,         |
|   eta, classe): bool                          |
| + StampaStudenti(): void                      |
| + StampaStudente(id, studente): void          |
| - TrovaId(studente): int                      |
+------------------------------------------------+
*/

public class GestioneStudenti
{
    private List<Studente> studenti;
    private Dictionary<int, Studente> rubrica;

    public GestioneStudenti()
    {
        studenti = new List<Studente>();
        rubrica = new Dictionary<int, Studente>();
    }

    /// <summary>
    /// Aggiunge lo studente alla lista e al dizionario
    /// </summary>
    public bool AggiungiStudente(int id, Studente studente)
    {
        if (rubrica.ContainsKey(id))
        {
            return false;
        }

        studenti.Add(studente);
        rubrica.Add(id, studente);
        return true;
    }

    /// <summary>
    /// Rimuove lo studente dalla lista e dal dizionario
    /// </summary>
    public bool RimuoviStudente(int id)
    {
        if (!rubrica.ContainsKey(id))
        {
            return false;
        }

        Studente studente = rubrica[id];
        studenti.Remove(studente);
        rubrica.Remove(id);
        return true;
    }

    /// <summary>
    /// Cerca velocemente uno studente tramite il suo ID
    /// </summary>
    public Studente? CercaStudente(int id)
    {
        if (rubrica.ContainsKey(id))
        {
            return rubrica[id];
        }

        return null;
    }

    /// <summary>
    /// Modifica i dati dello studente con l'ID indicato
    /// </summary>
    public bool ModificaStudente(int id, string nome, string cognome, int eta, string classe)
    {
        if (!rubrica.ContainsKey(id))
        {
            return false;
        }

        Studente studente = rubrica[id];
        studente.Nome = nome;
        studente.Cognome = cognome;
        studente.Eta = eta;
        studente.Classe = classe;
        return true;
    }

    /// <summary>
    /// Visualizza tutti gli studenti mantenendo l'ordine della lista
    /// </summary>
    public void StampaStudenti()
    {
        if (studenti.Count == 0)
        {
            Console.WriteLine("Non sono presenti studenti.");
        }

        for (int i = 0; i < studenti.Count; i++)
        {
            Studente studente = studenti[i];
            int id = TrovaId(studente);
            StampaStudente(id, studente);
        }
    }

    /// <summary>
    /// Visualizza i dati di uno studente
    /// </summary>
    public void StampaStudente(int id, Studente studente)
    {
        Console.WriteLine($"ID: {id} - {studente.Nome} {studente.Cognome}, " +
            $"{studente.Eta} anni, classe {studente.Classe}");
    }

    private int TrovaId(Studente studente)
    {
        foreach (KeyValuePair<int, Studente> elemento in rubrica)
        {
            if (elemento.Value == studente)
            {
                return elemento.Key;
            }
        }

        return -1;
    }
}
