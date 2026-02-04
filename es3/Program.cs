namespace es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 3");

            string stringa;

            Console.Write("Inserisci una stringa: ");
            stringa = Console.ReadLine();

            string parte1 = stringa.Substring(0, stringa.Length / 2);
            string parte2 = stringa.Substring(stringa.Length / 2, stringa.Length - (stringa.Length / 2));

            Console.WriteLine(parte1);
            Console.WriteLine(parte2);
        }
    }
}
