namespace Andrea_Maffiotto_Modulo_3;

public class Contatore
{
    /*
     *  +----------------------------------+
     *  |            Contatore             |
     *  +----------------------------------+
     *  |   - conteggio; int               |
     *  |   + TotaleIstanza; int {static}  |
     *  |   + Conteggio; int {get; set;}   |
     *  +----------------------------------+
     *  |   + ResetTotale() {static}       |
     *  +----------------------------------+
     */
    
    private int conteggio;
    public static int TotaleIstanza = 0;
    public Contatore()
    {
        Conteggio = 0;
        TotaleIstanza++;
    }
    
    public int Conteggio
    {
        get => conteggio;
        set => conteggio = value;
    }
    /// <summary>
    /// Resetta il valore di totale istanza
    /// </summary>
    public static void ResetTotale()
    {
        TotaleIstanza = 0;
    }
}