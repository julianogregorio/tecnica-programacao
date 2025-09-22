using System;
using Biblioteca;
class ExerciseThree
{
    static int getMin(int[] meuArray)
    {
        int min = meuArray [0];
        
        for (int i = 0; i < meuArray.Length; i++)
        {
            if (meuArray[i] < min){
            min = meuArray[i];
            }
        }

        return min;
    }
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        Console.WriteLine("\nO menor valor do vetor é: " + getMin(meuArray));

    }
}