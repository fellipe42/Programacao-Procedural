using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        int numeroDeNomes = 10;
        string nome;
        int contador;

        System.Console.WriteLine($"Insira {numeroDeNomes} nomes: ");

        for (int i = 0; i < numeroDeNomes; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        System.Console.WriteLine("Insira o nome que deseja buscar na lista: ");
        nome = Console.ReadLine();

        for (contador = 0; contador < numeroDeNomes; contador++)
        {
            if (nomes[contador] == nome)
            {
                Console.WriteLine("ACHEI");
                break;
            }
            else if (contador == (numeroDeNomes - 1))
            {
                Console.WriteLine("NAO ACHEI");
                break;
            }
        }
    }
}
