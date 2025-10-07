using System;
using minhaBiblioteca;

class Exercicio3{
	
	static void gerarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Random rand = new Random(); //criando o gerador de números aleatórios
            Console.WriteLine("Gerando matriz...");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = rand.Next(02);
                }//fim do for do J
            }//fim do for do i
        
		}	
		
	static double contarOcupacao(int [,] matriz){
		double ocupacao=0;
		
		int linhas = matriz.GetLength(0);
		int cols = matriz.GetLength(1);
		
		for(int i=0; i<linhas; i++){
			for(int j=0; j<cols; j++){
				if(matriz[i,j]==1){
					ocupacao++;
				}
			}
		}
		
		
		return ocupacao;
	}
	
	static void Main(){
		
		int linhas = 4, cols = 5;
		
		int [,] matrizPassada = new int [linhas, cols];
		
		gerarMatriz(matrizPassada);
		Console.WriteLine("\n==Ocupação da semana passada===");
		Biblioteca.escreverMatriz(matrizPassada);
		
		int [,] matrizAtual = new int [linhas, cols];
		
		gerarMatriz(matrizAtual);
		Console.WriteLine("\n==Ocupação atual===");
		Biblioteca.escreverMatriz(matrizAtual);
		
		double ocupacaoPassada = contarOcupacao(matrizPassada);
		double ocupacaoAtual = contarOcupacao(matrizAtual);
		
		Console.WriteLine($"Percentual de ocupação passada: {ocupacaoPassada/(linhas*cols)*100:F2}"); 
		Console.WriteLine($"Percentual de ocupação atual: {ocupacaoAtual/(linhas*cols)*100:F2}");
		
		if(ocupacaoPassada>ocupacaoAtual){
			Console.WriteLine("Houve redução na taxa de ocupação");
		}else{
			if(ocupacaoPassada<ocupacaoAtual){
				Console.WriteLine("Houve aumento na taxa de ocupação");
			}else{
				Console.WriteLine("Não houve alteração!");
			}
			
		}
		
		
	}
}