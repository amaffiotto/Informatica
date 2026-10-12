namespace Andrea_Maffiotto_Modulo_3;

public class Logger
{
    private static Logger _istanza;

    private Logger()
    {
        
    }

    public static Logger Instanza()
    {
        if (_istanza == null)
        {
            _istanza = new Logger();
        }

        return _istanza;
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}