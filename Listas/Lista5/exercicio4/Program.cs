//Crie um programa que receba números inteiros através do teclado e 
//acumule todos os números ímpares digitados em um somatório. 
// Quando um número negativo for digitado, seu programa deve parar de acumular os números e exibir o resultado do somatório de ímpares.
//OBS: O número negativo não deve ser adicionado ao somatório.
using System;

class Program
{
    static void Main(string[] args)
    {

        int numeroDigitado = 0;
        int somatorio = 0;

        Console.WriteLine("Insira numeros inteiros: ");

        do
        {
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado % 2 == 1 && numeroDigitado > 0)
            {
                somatorio = somatorio + numeroDigitado;
            }
        }
        while (numeroDigitado >= 0);

        Console.WriteLine($"a soma de numeros impares foi igual a: {somatorio}");
    }
}