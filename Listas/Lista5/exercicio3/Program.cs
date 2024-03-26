using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o tamanho da altura do retangulo: ");
        int alturaDoRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o tamanho da base do retangulo");
        int baseDoRetangulo = int.Parse(Console.ReadLine());

        for (int contadorLinha = 0; contadorLinha < alturaDoRetangulo; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna < baseDoRetangulo; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}