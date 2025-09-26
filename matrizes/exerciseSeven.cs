using System;
using minhaBiblioteca;

class ExerciseSeven
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
    static void getSub(int[,] matrizUm, int[,] matrizDois)
    {

        int linhas = matrizUm.GetLength(0);
        int cols = matrizUm.GetLength(1);

        int[,] matrizProduto = new int[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrizProduto[i, j] = matrizUm[i, j] - matrizDois[i, j];
            }
        }
        Console.WriteLine("\n== Matriz 1 - Matriz 2 ==");
        biblioteca.escreverMatriz(matrizProduto);
    }

    static void OpcaoUm()
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
    static void OpcaoDois()
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

        getSub(matrizUm, matrizDois);

    }

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n====Menu====");
            Console.WriteLine("1 - Somar duas matrizes");
            Console.WriteLine("2 - Subtrair duas matrizes");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite sua escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    OpcaoUm();
                    break;

                case 2:
                    OpcaoDois();
                    break;

                case 0:
                    Console.WriteLine("\nSaindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);

    }

}