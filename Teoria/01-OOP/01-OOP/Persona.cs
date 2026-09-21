namespace _01_OOP;

internal class Persona
{
    private string nome;
    private string cognome;
    private int eta;

    public Persona(string nome, string cognome, int eta)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.Eta = eta;
    }

    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    public string Cognome
    {
        get => cognome;
        set => cognome = value;
    }

    public int Eta
    {
        get => eta;
        set
        {
            if (value > 0)
            {
                eta = value;
            }
        }
    }
}