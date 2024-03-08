using System;

class Program
{
    static void Main(string [] args)
    {
        int valorGasto = 0;
        int quantidadeDeLidas = 0;

            Console.WriteLine("Digite a quantidade de itens comprados \n");
        int quantidadeDeItens = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preco de cada um dos itens \n");

        while (quantidadeDeLidas < quantidadeDeItens)
        {
            quantidadeDeLidas ++;
            int ValorDoItem = int.Parse(Console.ReadLine());
            valorGasto = (valorGasto + ValorDoItem);
        }

        if (valorGasto >= 150)
        {
            Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor R$" + valorGasto);
        }
        else 
        {
            Console.WriteLine("A compra nao possui frete gratis");
        }
    }
}
