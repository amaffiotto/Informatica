namespace Andrea_Maffiotto_Modulo_3;

// Esercizio 3.2
public class Configurazione
{
    public static string Impostazioni { get; set; }

    static Configurazione()
    {
        Impostazioni = "Iniziale";
    }
}