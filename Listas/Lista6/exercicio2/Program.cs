using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        int quantidadeDeNomes = 10;
        int decontador = 0;

        System.Console.WriteLine("Insira 10 nomes: ");

        for (int i = 0; i < quantidadeDeNomes; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        for (int contador = 9; contador >= decontador; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(nomes[contador]);
            }
        }
    }
}