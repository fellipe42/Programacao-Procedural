using System;
struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;

}

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Produto[] vetor = new Produto[TAMANHO_VETOR];

        for (int contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            vetor[contador].id = int.Parse(Console.ReadLine());
            vetor[contador].nome = Console.ReadLine();
            vetor[contador].preco = double.Parse(Console.ReadLine());
            vetor[contador].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for (int contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            if (vetor[contador].disponivelEmEstoque == true)
            {
                Console.WriteLine(vetor[contador].nome);
                Console.WriteLine(vetor[contador].preco);
            }
        }

    }
}