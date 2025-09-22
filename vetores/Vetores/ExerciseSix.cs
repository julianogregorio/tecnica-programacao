using System;
using Biblioteca;
class ExerciseSix
{
    static int getChoice(int[] meuArray)
    {
        int choice;
        bool found = false;

        Console.WriteLine("\nEscolha um número: ");
        choice = int.Parse(Console.ReadLine());

        for (int i = 0; i < meuArray.Length; i++)
        {
            if (choice == meuArray[i])
            {
                found = true;
                return i;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nO número " + choice + " não está no vetor");

        }
        
        return -1;
    }
    static void Main()
    {
        int n, pos;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        pos = getChoice(meuArray);
        if (pos != -1)
        {
            Console.WriteLine("\nO número escolhido ocupa a seguinte posição: " + pos);
        }

    }
}