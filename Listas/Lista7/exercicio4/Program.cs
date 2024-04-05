using System;
using System.Runtime.InteropServices;

class Program
{

    static void PreencheVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void TestePeso(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > 50)
            {
                Console.WriteLine((i + 1) + "º vagao ultrapassou o limite de peso");
            }
        }
    }
    static void Main(string[] args)
    {
        const int TAMANHO_TREM = 12;
        int[] trem = new int[TAMANHO_TREM];

        Console.WriteLine("Insira o peso de cada um dos " + TAMANHO_TREM + " vagoes");
        PreencheVetor(trem);
        TestePeso(trem);
    }
}