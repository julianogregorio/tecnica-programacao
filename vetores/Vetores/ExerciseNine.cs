using System;
using Biblioteca;

class ExerciseNine
{
    static void getReverse(int[] meuArray)
    {
        Console.WriteLine("\nVetor invertido:");
        for (int i = meuArray.Length - 1; i >= 0; i--)
        {
            Console.Write("|" + meuArray[i]);
        }
        Console.WriteLine(); 
    }

    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        getReverse(meuArray);
    }
}
