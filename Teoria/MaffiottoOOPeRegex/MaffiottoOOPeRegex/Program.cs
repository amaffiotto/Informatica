using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoOOPeRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ES 2
            List<Materiale> materiali = new List<Materiale>();
            Libro l1 = new Libro("La Chimera", "AA000", "Roberto Vassalli");
            Libro l2 = new Libro("Sparta e Atene", "AA001", "Eva Cantarella");
            Rivista r1 = new Rivista("Dylan Dog", "AA002", 12);
            Rivista r2 = new Rivista("Tempo", "AA003", 12);
            DVD d1 = new DVD("Tom Pearl", "AA004", 120);

            materiali.Add(l1);
            materiali.Add(l2);
            materiali.Add(r1);
            materiali.Add(r2);
            materiali.Add(d1);

            foreach (var item in materiali)
            {
                Console.WriteLine(item.Descrivi());
            }

            // ES 3
            Queue<string> listaDiAttesa = new Queue<string>();
            listaDiAttesa.Enqueue("Marco");
            listaDiAttesa.Enqueue("Andrea");
            Console.WriteLine($"Prossimo in coda: {listaDiAttesa.Peek()}");
            Console.WriteLine($"Prestito fatto, {listaDiAttesa.Dequeue()} Rimosso dalla lista di attesa");

            // ES 4

            Dictionary<string, Materiale> dizionarioMateriali = new Dictionary<string, Materiale>();
            RiempiDizionarioConLista(dizionarioMateriali, materiali);
            Console.WriteLine("Inserisci un codice da cercare nel dictonary: ");
            string codiceToSearch = Console.ReadLine();
            Materiale matTrovato = TrovaDescrizione(codiceToSearch, dizionarioMateriali);
            if(matTrovato != null)
            {
                Console.WriteLine($"Descrizione materiale trovato: {matTrovato.Descrivi()}");
            }
            else
            {
                Console.WriteLine("Materiale NON trovato!!!");
            }
        }

        private static Materiale TrovaDescrizione(string codice, Dictionary<string, Materiale> dizionario)
        {
            dizionario.TryGetValue(codice, out var material);
            return material;
        }

        private static void RiempiDizionarioConLista(Dictionary<string, Materiale> dizionario,List<Materiale> lista)
        {
            foreach (var mat in lista)
            {
                dizionario.Add(mat.Codice, mat);
            }
        }
    }
}
