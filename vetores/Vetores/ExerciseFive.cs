using System;

class ExerciseFive
{
    static void Main()
    {
        
        char[] dna = new char[50];
        char[] complementar = new char[50];

        Console.WriteLine("Digite a quantidade de bases do DNA (máx. 50):");
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite a base {i + 1} (A, T, C ou G): ");
            dna[i] = char.ToUpper(Console.ReadLine()[0]);
        }

        
        for (int i = 0; i < n; i++)
        {
            if (dna[i] == 'A')
                complementar[i] = 'T';
            else if (dna[i] == 'T')
                complementar[i] = 'A';
            else if (dna[i] == 'C')
                complementar[i] = 'G';
            else if (dna[i] == 'G')
                complementar[i] = 'C';
            else
            {
                Console.WriteLine("Base inválida detectada. Use apenas A, T, C ou G.");
                return;
            }
        }

        
        Console.Write("Vetor complementar: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(complementar[i] + " ");
        }
    }
}
