using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

            Console.WriteLine("Insira 9 numeros inteiros, a diagonal invertida da matriz apresentada tera seus valores dobrados: ");
        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if (linha == 0 && coluna == 2 || linha == 1 && coluna == 1 || linha == 2 && coluna == 0)
                {
                    matriz[linha, coluna] = int.Parse(Console.ReadLine()) * 2;
                }
                else
                {
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

        }

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Console.Write(matriz[linha, coluna] + "|");
            }
            Console.WriteLine();
        }
    }
}
