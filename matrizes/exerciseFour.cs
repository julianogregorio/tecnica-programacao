using System;
using System.Drawing;
using minhaBiblioteca;


class ExerciseFour {

    static void getDigMain(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("===Diagonal principal===");
        for (int i = 0; i < linhas; i++)
        {
            int j = i;
            Console.WriteLine($"Linha {i} coluna {j} valor: {matriz[i,j]}");
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
        biblioteca.mostrarMatriz(matriz);

        getDigMain(matriz);


    }
}