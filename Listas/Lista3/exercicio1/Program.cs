using System;

class Program 
{
    static void Main(string[] args)
    {
        const int NUMERO_PESSOAS = 20;
        int salarioDigitado = 0;
        int qtdFilhos = 0;
        int somatoriaSalarios = 0;
        int somatoriaFilhos = 0;
        int maiorSalario = 0;

        {
            for (int contador = 0; contador < NUMERO_PESSOAS; contador ++)
            {
                Console.WriteLine("Digite seu salario");
                salarioDigitado = int.Parse(Console.ReadLine());
                somatoriaSalarios = (somatoriaSalarios + salarioDigitado);

                Console.WriteLine("Digite a quantidade de filhos que possui");
                qtdFilhos = int.Parse(Console.ReadLine());
                somatoriaFilhos = (somatoriaFilhos + qtdFilhos);

                if (salarioDigitado > maiorSalario)
                {
                    maiorSalario = salarioDigitado;
                }
            }
            
            double mediaSalarial = (somatoriaSalarios / NUMERO_PESSOAS);
            int mediaFilhos = (somatoriaFilhos / NUMERO_PESSOAS);
            Console.WriteLine("Media salarial = " + Math.Round(mediaSalarial, 2) + " R$ \n" + "Media do numero de filhos por habitante = " + mediaFilhos);
            Console.WriteLine("Maior salario = " + maiorSalario + " R$");
        }

    }
}