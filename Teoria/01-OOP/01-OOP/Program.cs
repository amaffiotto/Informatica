namespace _01_OOP;

class Program
{
    static void Main(string[] args)
    {
        int cont;

        Persona p1;
        p1 = new Persona("Aldo", "Rossi", 32);
        Persona p2 = new Persona("Miguel", "Kasneci", -22);

        Console.WriteLine($"Persona 1 = {p1.Nome} {p1.Cognome} {p1.Eta}");
        Console.WriteLine($"Persona 2 = {p2.Nome} {p2.Cognome} {p2.Eta}");
    }
}