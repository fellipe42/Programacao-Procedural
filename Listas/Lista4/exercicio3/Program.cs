using System;
using System.Xml;
using Microsoft.VisualBasic;

class Program
{
    static void Main(String[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        for (int coluna = 0; coluna < 8; coluna++)
        {
            for (int linha = 0; linha < 8; linha++)
            {
                if (coluna == 0 || coluna == 7 || linha == 0 || linha == 7)
                {
                    Tabuleiro.Adicionar(linha, coluna, "S");
                }
            }
        }
        
        Tabuleiro.ImprimeTabuleiro();
    }
}