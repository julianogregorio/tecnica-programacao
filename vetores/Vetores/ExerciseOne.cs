using System;
using Biblioteca;
class ExerciseOne
{
    static int getSum(int[] meuArray)
    {
        int sum = 0;
        int sizeVector = meuArray.Length;

        for (int i = 0; i < sizeVector; i++)
        {
            sum += meuArray[i];
        }

        return sum;
    }
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        Console.WriteLine("\nA soma dos valores do vetor é: " + getSum(meuArray));

    }
}