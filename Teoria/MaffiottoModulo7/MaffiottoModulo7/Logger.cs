namespace MaffiottoModulo7;

/*
+------------------------------------------+
|          Logger {singleton}              |
+------------------------------------------+
| - _istanza: Logger {static}              |
| - _lock: object {static, readonly}       |
+------------------------------------------+
| - Logger()                               |
| + Instance: Logger {static, get;}        |
| + Log(messaggio: string): void           |
+------------------------------------------+
*/

public class Logger
{
    private static Logger? _istanza;
    private static readonly object _lock = new object();

    /// <summary>
    /// Impedisce la creazione diretta di altri Logger
    /// </summary>
    private Logger()
    {

    }

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
    /// Visualizza un messaggio di log con data e ora
    /// </summary>
    public void Log(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] LOG: {messaggio}");
    }
}
