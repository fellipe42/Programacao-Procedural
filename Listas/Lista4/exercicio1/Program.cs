using System;

class Program 
{
    static void Main(string[] args)
    {
        int contadorMaior = 1;

        while (contadorMaior <10)
        {
            for (int contador = 1; contador <= 10; contador ++)
            {
                Console.WriteLine(contadorMaior + " x " + contador + " = " + (contadorMaior * contador));
            }
            contadorMaior ++;
            Console.WriteLine("\n");
        }
        
    }
}