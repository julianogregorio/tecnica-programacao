using System;
using minhaBiblioteca;

class ExerciseThree
{
    static int getEqu(int[,] matriz)
    {
        int contEqu = 0;
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("Digite o valor que você deseja procurar na matriz: ");
        int equ = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == equ)
                {
                    contEqu ++; 
                }

            }//fim do for do J
        }//fim do for do i

        return contEqu;



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



        Console.WriteLine("Número de ocorrências: " + getEqu(matriz));



    }
}