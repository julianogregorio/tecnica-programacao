using System;
using minhaBiblioteca;

class ExerciseTen
{

    static void escreverMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("\nMatriz das tropas (Quantidade de Tropas por Cidade):");

        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"Região {i + 1}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void somarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int soma = 0;

        Console.WriteLine("\nForça total das Regiões");

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                soma += matriz[i, j];
            }
            Console.Write($"Região {i + 1}: {soma} tropas");
            soma = 0;
            Console.WriteLine();
        }
    }


    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas da matriz: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];
        biblioteca.gerarMatriz(matriz);
        escreverMatriz(matriz);
        somarMatriz(matriz);


    }
}