namespace es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 4");

            string frase, fraseContrario = "";

            Console.WriteLine("Inserisci una frase");
            frase = Console.ReadLine();

            string[] fraseDiv = frase.Split(' ');

            for (int i = fraseDiv.Length - 1; i >= 0; i--)
            {

                fraseContrario = fraseContrario + fraseDiv[i];
                fraseContrario = fraseContrario + " ";

            }

            Console.WriteLine(fraseContrario);
        }
    }
}
