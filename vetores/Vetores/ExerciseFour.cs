using System;
using Biblioteca;
class ExerciseFour
{
    static int getMax(int[] meuArray)
    {
        int max = meuArray [0];
        
        for (int i = 0; i < meuArray.Length; i++)
        {
            if (meuArray[i] > max){
            max = meuArray[i];
            }
        }

        return max;
    }
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        Console.WriteLine("\nO maior valor do vetor é: " + getMax(meuArray));

    }
}