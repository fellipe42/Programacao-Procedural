using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Insira a quantidade de centavos que deseja converter");
      double TotalCentavos = double.Parse(Console.ReadLine());

      double Reais = (TotalCentavos / 100);
      double Centavos = (TotalCentavos % 100);

    Console.WriteLine("O total em dinheiro eh: " + Reais + " real(is) e " + Centavos + " centavo(s).");

    }
}
