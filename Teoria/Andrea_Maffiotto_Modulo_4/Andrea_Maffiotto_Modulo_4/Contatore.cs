namespace Andrea_Maffiotto_Modulo_4;

public class Contatore
{
    /*
     *  +------------------------------------------+
     *  |                Contatore                 |
     *  +------------------------------------------+
     *  | - valore: int                           |
     *  | - totaleIstanze: int {static}            |
     *  +------------------------------------------+
     *  | - Contatore()                            |
     *  | + CreaContatore(): Contatore {static}    |
     *  | + Incrementa(): void                     |
     *  | + ResetTotale(): void {static}           |
     *  | + Valore: int {get;}                     |
     *  | + TotaleIstanze: int {static, get;}      |
     *  +------------------------------------------+
     */

    private int valore;
    private static int totaleIstanze;

    /// <summary>
    /// Inizializza il contatore
    /// </summary>
    private Contatore()
    {
        valore = 0;
        totaleIstanze++;
    }

    /// <summary>
    /// Restituisce il valore del contatore
    /// </summary>
    public int Valore
    {
        get => valore;
    }

    /// <summary>
    /// Restituisce il totale delle istanze create
    /// </summary>
    public static int TotaleIstanze
    {
        get => totaleIstanze;
    }

    /// <summary>
    /// Crea un nuovo contatore
    /// </summary>
    public static Contatore CreaContatore()
    {
        return new Contatore();
    }

    /// <summary>
    /// Incrementa il valore del contatore
    /// </summary>
    public void Incrementa()
    {
        valore++;
    }

    /// <summary>
    /// Resetta il totale delle istanze create
    /// </summary>
    public static void ResetTotale()
    {
        totaleIstanze = 0;
    }
}
