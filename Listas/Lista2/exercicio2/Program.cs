using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira a nota 1");
        Double Nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a nota 2");
        double Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a nota 3");
        double Nota3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota 4");
        double Nota4 = double.Parse(Console.ReadLine());

        double Media = ((Nota1 + Nota2 + Nota3 + Nota4) / 4);
        Console.WriteLine("A media eh: " + Media);    

        bool Aprovado = (Media >= 5);
        bool Recuperacao = (Media < 5) && (Media >= 3);

        if (Aprovado == true)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (Recuperacao == true)
        {
            Console.WriteLine("Aluno em recuperacao");
        }        
        else
        {
            Console.WriteLine("Aluno reprovado");   
        }
                 
    }
}