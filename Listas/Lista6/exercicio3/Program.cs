using System;

class Program
{
    static void Main(string[] args)
    {

        const int LINHAS = 3;
        const int COLUNAS = 3;
        int somatorio = 0;

        int[,] numeros = new int[LINHAS, COLUNAS];

        Console.WriteLine("Insira 9 numeros inteiros");


        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        somatorio = (numeros[0, 0] + numeros[1, 1] + numeros[2, 2]);
        Console.WriteLine(somatorio);
    }
}