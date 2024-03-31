using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        int[] numeros = new int[TAMANHO_VETOR];
        int contador = 0;
        int entrada = 0;

        Console.WriteLine("Insira numeros inteiros: ");

        do
        {
            entrada = int.Parse(Console.ReadLine());
            if (entrada >= 10 && entrada <= 50)
            {
                numeros[contador] = entrada;
                contador++;
            }

        } while (contador < TAMANHO_VETOR);

        Console.WriteLine();

        for (int colunas = 0; colunas < TAMANHO_VETOR; colunas++)
        {
            Console.WriteLine(numeros[colunas]);
        }
    }
}