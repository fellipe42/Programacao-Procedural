using System;

class Program
{
    static void Main(string[] args)
    {
        const int LIMITE_CRESCENTE = 100;
        const int LIMITE_DECRESCENTE = 0;
        int contador = 0;
        int decontador = 200;

        for (contador = 0, decontador = 200; contador <= LIMITE_CRESCENTE && decontador >= LIMITE_DECRESCENTE;
            contador += 2, decontador -= 4)
        {
            Console.WriteLine(contador + "-" + decontador);
        }
    }
}