namespace esercizistringhe2
{
    internal class Program
    {
        static int Trasformazione(string num)
        {
            int numeroTras = 0, potenza, cont = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '1')
                {
                    potenza = (int)Math.Pow(2, cont);
                    numeroTras = numeroTras + potenza;
                    cont = cont + 1;
                }
                else
                {
                    numeroTras = numeroTras + 0;
                    cont = cont + 1;
                }
            }

            return numeroTras;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1");

            string numero;

            Console.WriteLine("Inserisci il numero binario di 8 bit: ");
            numero = Console.ReadLine();

            Console.WriteLine($"Numero in decimale: {Trasformazione(numero)} ");

        }
    }
}
