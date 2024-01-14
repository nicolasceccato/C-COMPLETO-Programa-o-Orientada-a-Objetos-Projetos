using System;
using tabuleiro;
using xadrez_console;

namespace Xadrez // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}