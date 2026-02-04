namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 2");

            string frase, frasePulita = "";

            Console.Write("Inserisci una frase: ");
            frase = Console.ReadLine();

            string fraseTrim = frase.Trim();

            string[] fraseDivisa = fraseTrim.Split(' ');

            for (int i = 0; i < fraseDivisa.Length; i++)
            {

                if (fraseDivisa[i] != " ")
                {
                    frasePulita = frasePulita + fraseDivisa[i];
                    frasePulita = frasePulita + " ";
                }

            }

            frasePulita = frasePulita.Trim();

            Console.WriteLine($"La frase pulita è: '{frasePulita}'");
        }
    }
}
