using System;
using System.Threading.Channels;

class Program
{

    static bool Ehpar(int parametro)
    {
        return parametro % 2 == 0;
    } 
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        bool resultado = Ehpar(numero); 
        Console.WriteLine(resultado);
    }
}

