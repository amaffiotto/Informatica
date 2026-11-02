namespace MaffiottoModulo7;

/*
+----------------------------------+
|             Studente             |
+----------------------------------+
| - _nome: string                  |
| - _cognome: string               |
| - _eta: int                      |
| - _classe: string                |
+----------------------------------+
| + Studente(nome, cognome,        |
|   eta, classe)                   |
| + Nome: string                   |
| + Cognome: string                |
| + Eta: int                       |
| + Classe: string                 |
+----------------------------------+
*/

public class Studente
{
    private string _nome = "";
    private string _cognome = "";
    private int _eta;
    private string _classe = "";

    public Studente(string nome, string cognome, int eta, string classe)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
        Classe = classe;
    }

    public string Nome
    {
        get => _nome;
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Il nome non può essere vuoto.");
            }

            _nome = value;
        }
    }

    public string Cognome
    {
        get => _cognome;
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Il cognome non può essere vuoto.");
            }

            _cognome = value;
        }
    }

    public int Eta
    {
        get => _eta;
        set
        {
            if (value < 0 || value > 122)
            {
                throw new ArgumentOutOfRangeException("L'età deve essere compresa tra 0 e 122.");
            }

            _eta = value;
        }
    }

    public string Classe
    {
        get => _classe;
        set
        {
            if (value == "")
            {
                throw new ArgumentException("La classe non può essere vuota.");
            }

            _classe = value;
        }
    }
}
