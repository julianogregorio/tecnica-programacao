using System;
using Biblioteca;
class ExerciseTen
{
    static void getOcc(int[] meuArray)
    {
        int[] occurrence = new int[6];

        for (int i = 0; i < meuArray.Length; i++)
        {
            int value = meuArray[i];
            if (value >= 1 && value <= 6)
            {
                occurrence[value - 1]++;
            }
        }

        for (int i = 0; i < occurrence.Length; i++)
        {
            Console.WriteLine($"Face {i+1}: {occurrence[i]} ocorrênicas(s)");
        }

        
    }
    static void Main()
    {
        int n;
        Console.Write("Digite quantas vezes o dado foi lançado: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVetor.gerarVetorDados(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);

        Console.WriteLine("\nOcorrências das fases: ");
        getOcc(meuArray);

    }
}