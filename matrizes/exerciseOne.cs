using System;
using minhaBiblioteca;

class ExerciseOne
{
    static int getMin(int[,] matriz) {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        int menor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }

            }//fim do for do J
        }//fim do for do i

        return menor;



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



        Console.WriteLine("Menor valor: " + getMin(matriz));



    }
}