using System;

class Program
{
    static string ClassificarNadador(int idade)
    {
        if (idade < 12)
        {
            return "infantil";
        }
        else if (idade >= 12 && idade <= 14)
        {
            return "Juvenil A";
        }
        else if (idade >= 15 && idade <= 17)
        {
            return "Juvenil B";
        }
        else if (idade >= 18)
        {
            return "Adulto";
        }
        else
        {
            return "Insira uma idade valida";
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a idade do jogador: ");

        int idade = int.Parse(Console.ReadLine());

        string resultado = ClassificarNadador(idade);

        Console.WriteLine(resultado);
    }
}
