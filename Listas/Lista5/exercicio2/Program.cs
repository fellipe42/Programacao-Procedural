using System;

class Program
{
    static void Main(string[] args)
    {
        int primeiroFator = 10;

        while (primeiroFator > 0)
        {
            for (int segundoFator = 1; segundoFator <= 10; segundoFator++)
            {
                Console.WriteLine($"{primeiroFator} x {segundoFator} = {primeiroFator * segundoFator}");
            }
            primeiroFator--;
            Console.WriteLine("\n");
        }
    }
}