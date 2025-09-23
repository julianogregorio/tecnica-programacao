using System;
using Biblioteca;
class ExerciseSeven
{
    static void getMul(int[] meuArrayUm, int[] meuArrayDois)
    {
        int n = meuArrayUm.Length;
        int[] meuArrayTres = new int[n];

        int mul = 0;

        for (int i = 0; i < meuArrayUm.Length; i++)
        {
            mul = meuArrayUm[i] * meuArrayDois[i];
            meuArrayTres[i] = mul;
        }

        Console.WriteLine("\n\n****Vetor 1 x Vetor 2****");
        Console.WriteLine("Dados do Vetor:");
        for (int i = 0; i < meuArrayUm.Length; i++)
        {
            Console.Write("|" + meuArrayTres[i]);
        }
        
    }
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho dos vetores: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArrayUm = new int[n];
        int[] meuArrayDois = new int[n];

        BibliotecaVetor.gerarVetor(meuArrayUm);
        BibliotecaVetor.gerarVetor(meuArrayDois);

        Console.WriteLine("\n****Vetor 1****");
        BibliotecaVetor.mostrarVetor(meuArrayUm);
        Console.WriteLine();
        Console.WriteLine("\n****Vetor 2****");
        BibliotecaVetor.mostrarVetor(meuArrayDois);

        getMul(meuArrayUm, meuArrayDois);

    }
}