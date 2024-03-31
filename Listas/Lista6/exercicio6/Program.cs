using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        int opcao = 0;

        Console.WriteLine("Insira numeros inteiros: ");

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        do
        {
            Console.WriteLine("Insira um numero inteiro entre 1 e 5: ");
            opcao = int.Parse(Console.ReadLine());
            int somatorio = 0;

            if (opcao == 1)
            {
                Console.WriteLine();
                for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
                {
                    for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                    {
                        Console.WriteLine(matriz[linha, coluna]);
                    }
                }
                break;
            }
            else if (opcao == 2)
            {
                for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
                {
                    for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                    {
                        somatorio = somatorio + matriz[linha, coluna];
                    }
                }
                Console.Write(somatorio);
                break;
            }
            else if (opcao == 3)
            {
                for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
                {
                    for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                    {
                        if (linha == 2)
                        {
                            somatorio = somatorio + matriz[linha, coluna];
                        }
                    }
                }
                Console.Write(somatorio);
                break;
            }
            else if (opcao == 4)
            {
                for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
                {
                    for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                    {
                        if (linha == 0 && coluna == 0 || linha == 1 && coluna == 1 || linha == 2 && coluna == 2)
                        {
                            somatorio = somatorio + matriz[linha, coluna];
                        }
                    }
                }
                Console.Write(somatorio);
                break;
            }
            else
            {
                for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
                {
                    for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
                    {
                        if (linha == 2 && coluna == 0 || linha == 2 && coluna == 2)
                        {
                            somatorio = somatorio + matriz[linha, coluna];
                        }
                    }
                }
                Console.Write(somatorio);
                break;
            }

        } while (true);
    }
}