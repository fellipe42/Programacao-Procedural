using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a base do triangulo");
        Double ValorBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a altura do triangulo");
        double ValorAltura = double.Parse(Console.ReadLine());

        double Area = ((ValorBase * ValorAltura)/ 2);

        bool Resultado = Area > 20;
        Console.WriteLine("Qual a area do triangulo? " + Area);
        Console.WriteLine("A area do triangulo eh maior que 20? " + Resultado);
        
    }
}
