namespace Andrea_Maffiotto_Modulo_3;

public class Contatore
{
    // Esercizio 3.1
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
    public static void ResetTotaleIstanza()
    {
        TotaleIstanza = 0;
    }
}