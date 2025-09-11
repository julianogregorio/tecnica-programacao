using System;
using minhaBiblioteca;

class Program
{
    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];

        biblioteca.gerarMatriz(matriz);
        //biblioteca.lerMatriz(matriz);
        biblioteca.escreverMatriz(matriz);

    }
}