using System;
using System.Globalization;

class ExerciseTwelve
{
    static void Main()
    {
        Console.WriteLine("Digite as 5 notas separadas por espaço (use ponto como separador decimal):");
        string[] entrada = Console.ReadLine().Split();

        double[] notas = new double[5];
        for (int i = 0; i < 5; i++)
        {
            notas[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
        }

        double soma = 0;
        double menor = notas[0];
        double maior = notas[0];

        for (int i = 0; i < 5; i++)
        {
            soma += notas[i];

            if (notas[i] < menor)
                menor = notas[i];

            if (notas[i] > maior)
                maior = notas[i];
        }

        double resultado = soma - menor - maior;

        Console.WriteLine("Nota final igual a " + resultado.ToString("F1", CultureInfo.InvariantCulture));
    }
}
