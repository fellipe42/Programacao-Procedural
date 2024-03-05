using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual a crianca de hoje?");
        string nomeDeCrianca = Console.ReadLine();

        if (nomeDeCrianca == "Filomena")
        {
            Console.WriteLine("Rotina de Filomena: \n 1 Escola das 07h as 12h 2 Almoco das 12h as 13h \n 3 Futebol das 14h as 16h \n 4 Dever de casa das 16h as 18h");
        }
        else if (nomeDeCrianca == "Joselito")
        {
            Console.WriteLine("Rotina de Joselito: \n 1 Escola das 07h as 12:30 \n 2 Almoco das 13h as 14h \n 3 Natacao das 14h as 16h \n 4 Reforco escolar das 16h as 19h");
        }
        else
        {
            Console.WriteLine("Rotina nao encontrada");
        }
 
    }
}