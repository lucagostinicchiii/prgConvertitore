using System;

namespace prgConvertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resto;
            string numeroconvertito = "";
            int divisore;
            Console.WriteLine("inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci un divisore");
            divisore = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                resto = numero % divisore;
                numero = numero / 2;
                numeroconvertito = Convert.ToString(resto) + numeroconvertito;
            }
            Console.WriteLine($"{numeroconvertito}");
            Console.ReadLine();
        }
    }
}








               


