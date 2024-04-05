using System;

class Program
{
    static void PreencheMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
    }

    static bool TemBalista(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
            {
                if (matriz[linha, coluna] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] tabuleiro = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencheMatriz(tabuleiro);
        if (TemBalista(tabuleiro))
        {
            Console.WriteLine("Fique atento! Existem balistas no tabuleiro.");
        }
        else
        {
            Console.WriteLine("Não existem balistas no tabuleiro.");
        }
    }
}