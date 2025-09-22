using System;
using Biblioteca;
class ExerciseTwo
{
    static int getOdd(int[] meuArray)
    {
        int odd=0;
        
        for (int i = 0; i < meuArray.Length; i++)
        {
            if (meuArray[i] % 2 !=0){
                odd++;
            }
        }

        return odd;
    }
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        Console.WriteLine("\nA soma dos valores do vetor é: " + getOdd(meuArray));

    }
}