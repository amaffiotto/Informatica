namespace Andrea_Maffiotto_Modulo_4;

public class Configurazione
{
    /*
     *  +----------------------------------------------+
     *  |         Configurazione {singleton}           |
     *  +----------------------------------------------+
     *  | - _istanza: Configurazione {static, readonly}|
     *  +----------------------------------------------+
     *  | - Configurazione()                           |
     *  | + Instance: Configurazione {static, get;}     |
     *  | + Ambiente: string {get; set;}               |
     *  | + Versione: string {get; set;}               |
     *  +----------------------------------------------+
     */

    private static readonly Configurazione _istanza = new Configurazione();

    /// <summary>
    /// Inizializza la configurazione
    /// </summary>
    private Configurazione()
    {
        Ambiente = "Sviluppo";
        Versione = "1.0";
    }

    /// <summary>
    /// Restituisce l'unica configurazione
    /// </summary>
    public static Configurazione Instance
    {
        get => _istanza;
    }

    /// <summary>
    /// Ambiente dell'applicazione
    /// </summary>
    public string Ambiente { get; set; }

    /// <summary>
    /// Versione dell'applicazione
    /// </summary>
    public string Versione { get; set; }
}
