namespace OOP_Modulo_2;

class Program
{
    static void Main(string[] args)
    {
        Calcolatore s = new Calcolatore();

        Console.WriteLine($"La somma di 2 e 67 fa: {s.Somma(2, 67)}");
        Console.WriteLine($"La somma di 2,5 e 2,4 fa: {s.Somma(2.5,2.4)}");
        Console.WriteLine($"La somma di 3, 5, e 2 fa: {s.Somma(3,5,2)}");
    }
}