namespace AndreaMaffiottoModulo05;

public class Studente
{
    private string _nome;
    private string _cognome;
    private int _eta;

    public Studente(string n, string c, int e)
    {
        Nome = n;
        Cognome = c;
        Età = e;
    }

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Cognome
    {
        get => _cognome;
        set => _cognome = value;
    }

    public int Età
    {
        get => _eta;
        set
        {
            if (value < 0 || value > 122)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _eta = value;
            }
        }
    }
}