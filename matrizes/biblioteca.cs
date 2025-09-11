using System;
namespace minhaBiblioteca
{
    class biblioteca
    {
        public static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        Console.WriteLine("Entre com os dados da matriz: ");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}]:");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }//fim do for do J
        }//fim do for do i
    }
        public static void gerarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
            Random rand = new Random(); //criando o gerador de números aleatórios
        Console.WriteLine("Gerando matriz...");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                    matriz[i, j] = rand.Next(100); 
            }//fim do for do J
        }//fim do for do i
    }

    public static void escreverMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("****Matriz****");

        Console.WriteLine("Entre com os dados da matriz: ");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matriz[i, j] + " | ");
            }//fim do for do J
            Console.WriteLine();
        }//fim do for do i
    }
    }
}