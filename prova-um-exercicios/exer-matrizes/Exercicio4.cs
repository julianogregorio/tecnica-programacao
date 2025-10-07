using System;
using minhaBiblioteca;

class Exercicio4{
	
	static void producaoTotal(int [,] matriz){
		int linhas = matriz.GetLength(0);
		int cols = matriz.GetLength(1);
		double totalFazenda=0, totalGeral=0;		
		
		for(int i=0; i < linhas; i++){
			for(int j=0; j < cols; j++){
			totalFazenda += matriz[i,j];
			totalGeral += matriz[i,j];
			}//for colunas
			
			Console.WriteLine($"Total de produção da {i+1}º fazenda: {totalFazenda}");
			totalFazenda = 0;
			
		}//for linhas
		
		Console.WriteLine($"Total geral de produção: {totalGeral}");
		
	}
	
	static void crescimentoPercentual(int [,] matriz){
		int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        double maiorCrescimento = 0;
        int fazendaMaiorCrescimento = 0;

        for (int i = 0; i < linhas; i++)
        {
            double primeiroMes = matriz[i, 0];
            double ultimoMes = matriz[i, cols - 1];

            // evitar divisão por zero
            if (primeiroMes == 0) continue;

            double crescimento = ((ultimoMes - primeiroMes) / primeiroMes) * 100;

            Console.WriteLine($"Fazenda {i + 1}: crescimento de {crescimento:F2}%");

            if (crescimento > maiorCrescimento)
            {
                maiorCrescimento = crescimento;
                fazendaMaiorCrescimento = i;
            }
        }

        Console.WriteLine($"\nA fazenda com maior crescimento foi a {fazendaMaiorCrescimento + 1}ª, com {maiorCrescimento:F2}% de aumento.");
	}
	
	
	static void Main (){
		int linhas = 3, cols = 4;
		
		int [,] matriz = new int [linhas, cols];
		
		Biblioteca.gerarMatriz(matriz);
		Console.WriteLine("\n=== Matriz de Produção Agrícola===");
		Biblioteca.escreverMatriz(matriz);
		
		producaoTotal(matriz);
		crescimentoPercentual(matriz);
		
		
		Console.WriteLine("\n=== FIM-SE ===");
		
	}
}