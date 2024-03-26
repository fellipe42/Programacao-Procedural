using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Insira um numero inteiro entre 1 e 9: ");

        do
        {
            numero = int.Parse(Console.ReadLine());
            if (numero >= 1 && numero < 10)
            {
                break;
            }
            Console.WriteLine("altura invalida, insira uma altura entre 1 e 9");
        }
        while (true);

        for (int linha = 1; linha <= numero; linha++)
        {
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                Console.Write(coluna);
            }
            Console.WriteLine();

        }

    }
}
