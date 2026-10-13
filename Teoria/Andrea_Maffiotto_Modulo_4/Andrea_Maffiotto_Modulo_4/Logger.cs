namespace Andrea_Maffiotto_Modulo_4;

public class Logger
{
    /*
     *  +-------------------------------------------+
     *  |            Logger {singleton}             |
     *  +-------------------------------------------+
     *  | - _istanza: Logger {static}               |
     *  | - _lock: object {static, readonly}        |
     *  +-------------------------------------------+
     *  | - Logger()                                |
     *  | + Instance: Logger {static, get;}          |
     *  | + Log(messaggio: string): void            |
     *  +-------------------------------------------+
     */

    private static Logger? _istanza;
    private static readonly object _lock = new object();

    /// <summary>
    /// Inizializza il logger
    /// </summary>
    private Logger()
    {

    }

    /// <summary>
    /// Restituisce l'unica istanza del logger
    /// </summary>
    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_istanza == null)
                {
                    _istanza = new Logger();
                }

                return _istanza;
            }
        }
    }

    /// <summary>
    /// Visualizza un messaggio di log
    /// </summary>
    public void Log(string messaggio)
    {
        Console.WriteLine($"LOG: {messaggio}");
    }
}
