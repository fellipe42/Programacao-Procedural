using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static int MostraMaior(int[] vetor)
    {
        int maiorElemento = int.MinValue;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maiorElemento)
            {
                maiorElemento = vetor[i];
            }
        }
        return maiorElemento;
    }
    static void Main(string[] args)
    {
        int[] Entrada = new int[3];

        for (int i = 0; i < Entrada.Length; i++)
        {
           Entrada[i] = int.Parse(Console.ReadLine());
        }

        int resultado = MostraMaior(Entrada);
        Console.WriteLine(resultado);
    }
}
