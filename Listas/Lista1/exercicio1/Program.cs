using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a primeira nota do aluno");
        Double Nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a segunda nota");
        double Nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a terceira nota");
        double Nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a quarta nota");
        double Nota4 = double.Parse(Console.ReadLine());
        double Media = ((Nota1 + Nota2 + Nota3 + Nota4) / 4);
        Console.WriteLine("A media do aluno eh: " + Media);
        
    }
}
