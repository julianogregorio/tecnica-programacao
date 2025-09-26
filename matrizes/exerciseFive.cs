using System;
using System.Dynamic;
using System.Globalization;
using minhaBiblioteca;

class ExerciseFive
{
    static void getDigSec(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("===Diagonal secundária===");

        for (int i = 0; i <linhas; i++)
        {
            int j = cols - 1 - i;
            Console.WriteLine($"Linha {i} coluna {j} valor: {matriz[i, j]}");

        } 

    }
    static void Main()
    {
        int linhas, cols;

        Console.WriteLine("Entre com a quantidade de linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];

        biblioteca.gerarMatriz(matriz);
        biblioteca.escreverMatriz(matriz);

        getDigSec(matriz);

    }
}
