using System;
namespace Biblioteca
{
    public class BibliotecaVetor
    {
        public static void lerVetor(int[] vetor)
        {
            Console.WriteLine("Entre com os dados do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Array[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }// fim for
        }
        public static void gerarVetor(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);
        }
        public static void mostrarVetor(int[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);
        }

        public static void gerarVetorCaracteres(char[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                // 65 = 'A' | 90 = 'Z'
                vetor[i] = (char)aleatorio.Next(65, 91);
            }
        }

        public static void mostrarVetorCaracteres(char[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);
        }

        public static void gerarVetorDados(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 6);
        }

    }
}