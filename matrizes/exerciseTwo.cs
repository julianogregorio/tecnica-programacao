using System;
using minhaBiblioteca;

class ExerciseTwo
{
    static int getMax(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        int maior = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }

            }//fim do for do J
        }//fim do for do i

        return maior;



    }
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



        Console.WriteLine("Maior valor: " + getMax(matriz));



    }
}