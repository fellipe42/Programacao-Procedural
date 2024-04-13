using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;

}

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza1;

        pizza1.id = int.Parse(Console.ReadLine());
        pizza1.sabor = Console.ReadLine();
        pizza1.preco = double.Parse(Console.ReadLine());

        Console.WriteLine(pizza1.id);
        Console.WriteLine(pizza1.sabor);
        Console.WriteLine(pizza1.preco);

    }
}