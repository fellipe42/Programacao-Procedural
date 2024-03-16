using System;

class Program 
{
    static void Main(string[] args)
    {
        const string NOME_DE_USUARIO = "admin";
        const string SENHA = "123senha";
        const int MAXIMO_TENTATIVAS = 3;


        int contadorTentativas = 1;

        do
        {
            Console.WriteLine("\nDigite seu nome de usuário");
            string UsuarioDigitado = Console.ReadLine();

            Console.WriteLine("\nDigite sua senha");
            string SenhaDigitada = Console.ReadLine();

            contadorTentativas ++;

            if ((UsuarioDigitado == NOME_DE_USUARIO) && (SenhaDigitada == SENHA))
            {
                Console.WriteLine("Login realizado com sucesso");
                break;
            }
        }
        while (contadorTentativas <= MAXIMO_TENTATIVAS);

            if (contadorTentativas > MAXIMO_TENTATIVAS)
            {
                Console.WriteLine("Sua conta foi bloqueada");
            }

    }
}