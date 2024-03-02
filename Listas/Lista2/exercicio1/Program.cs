using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Insira o nome de usuario");
      String Usuario = (Console.ReadLine());

      Console.WriteLine("Insira a senha");
      String Senha = (Console.ReadLine());

      bool Resultado = (Usuario == "admin") && (Senha == "123senha");

      if (Resultado == true)
      {
        Console.WriteLine("Login realizado com sucesso!");
      }
      else
      {
        Console.WriteLine("Credenciais inválidas…");
      }

    }
}
