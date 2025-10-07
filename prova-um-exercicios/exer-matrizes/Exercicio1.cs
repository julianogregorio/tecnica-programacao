using System;
using minhaBiblioteca;

class Exercicio1{
	
	static double calculoMedia(int[,] matriz){
		
		int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
		double media=0;
		
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    media += matriz[i,j];
                }
                
            }
		
		media=media/(linhas*cols);
		return media;
	}
	static void Main(){
		int linhas = 4, cols= 4;
		int[,] matrizInicio = new int [linhas, cols];
		int[,] matrizFim = new int [linhas, cols];
		
		Console.WriteLine("\n===Início do mês===");
		Biblioteca.gerarMatriz(matrizInicio);
		Biblioteca.escreverMatriz(matrizInicio);
		
		Console.WriteLine("\n===Fim do mês===");
		Biblioteca.gerarMatriz(matrizFim);
		Biblioteca.escreverMatriz(matrizFim);
		
		double mediaInicio = calculoMedia(matrizInicio);
		Console.WriteLine($"\nMédia do início do mês {mediaInicio:F2}");
		
		double mediaFim = calculoMedia(matrizFim);
		Console.WriteLine($"Média do fim do mês {mediaFim:F2}");
		
		if(mediaInicio>mediaFim){
			Console.WriteLine("Houve diminuição da temperatura média");
		}else{
			if(mediaInicio<mediaFim){
				Console.WriteLine("Houve aumento da temperatura média");
			}else{
				Console.WriteLine("Houve estabilidade da temperatura média");
			}
		}
		
		//Console.WriteLine("Hello, World");
	}
}