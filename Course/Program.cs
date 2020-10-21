using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar ? ");
            int numbers = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int count = 1; count <= numbers; count++)
            {
                Console.Write("Valor #{0}: ", count);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
