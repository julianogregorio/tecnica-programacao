using System;
using minhaBiblioteca;

class ExerciseSix
{
    static void getSum(int[,] matrizUm, int[,] matrizDois)
    {

        int linhas = matrizUm.GetLength(0);
        int cols = matrizUm.GetLength(1);

        int[,] matrizProduto = new int[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrizProduto[i, j] = matrizUm[i, j] + matrizDois[i, j];
            }
        }
        Console.WriteLine("\n== Matriz 1 + Matriz 2 ==");
        biblioteca.escreverMatriz(matrizProduto);

    }

    static void Main()
    {
        int linhas, cols;

        Console.WriteLine("\n===CÁLCULO DE DUAS MATRIZES===");

        Console.WriteLine("Digite, respectivamente, o número de linhas e colunas das matrizes");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine("\n==Matriz 1==");
        int[,] matrizUm = new int[linhas, cols];

        biblioteca.gerarMatriz(matrizUm);
        biblioteca.escreverMatriz(matrizUm);

        Console.WriteLine("\n==Matriz 2==");
        int[,] matrizDois = new int[linhas, cols];

        biblioteca.gerarMatriz(matrizDois);
        biblioteca.escreverMatriz(matrizDois);

        getSum(matrizUm, matrizDois);

    }
}