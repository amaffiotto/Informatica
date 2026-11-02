namespace MaffiottoModulo7;

/*
+----------------------------------+
|            Contatore             |
+----------------------------------+
| - valore: int                    |
+----------------------------------+
| - Contatore()                    |
| + Valore: int {get;}             |
| + CreaContatore(): Contatore     |
| + Incrementa(): void             |
| + Reset(): void                  |
+----------------------------------+
*/

public class Contatore
{
    private int valore;

    /// <summary>
    /// Inizializza il contatore a zero
    /// </summary>
    private Contatore()
    {
        valore = 0;
    }

    public int Valore
    {
        get => valore;
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
    /// Riporta il valore del contatore a zero
    /// </summary>
    public void Reset()
    {
        valore = 0;
    }
}
