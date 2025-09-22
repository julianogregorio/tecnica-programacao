using System;
using Biblioteca;
class ExerciseEight
{
    static int getEqual(int[] meuArray)
    {
        int choice, rep=0;
        bool found = false;

        Console.WriteLine("\nEscolha um número: ");
        choice = int.Parse(Console.ReadLine());

        for (int i = 0; i < meuArray.Length; i++)
        {
            if (choice == meuArray[i])
            {
                rep++;
                
            }
        }
        return rep;
        if (!found)
        {
            Console.WriteLine("\nO número " + choice + " não está no vetor");

        }
        
        return -1;
    }
    static void Main()
    {
        int n, rep;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        rep = getEqual(meuArray);
        if (rep != -1)
        {
            Console.WriteLine("\nA frequência do número escolhido no vetor é igual a: " + rep);
        }

    }
}