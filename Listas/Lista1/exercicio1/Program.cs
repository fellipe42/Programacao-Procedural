using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade em dias");
        int idadeEmDias = int.Parse(Console.ReadLine());

        int anos = idadeEmDias / 365;
        bool maiorDeIdade = anos >= 18;

        Console.WriteLine("Essa pessoa é maior de idade? " + maiorDeIdade);
        
    }
}
