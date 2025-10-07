using System; 
using minhaBiblioteca; 

class Exercicio2{
	static void Main(){
		
		int linhas = 5, cols = 3;
		
		int [,] matrizReferencia = new int [linhas, cols];
		int [,] matrizMedicao = new int [linhas, cols];
		
		
		Biblioteca.gerarMatriz(matrizReferencia);
		Console.WriteLine("\n===Matriz de Referência===");
		Biblioteca.escreverMatriz(matrizReferencia);
		
		Biblioteca.gerarMatriz(matrizMedicao);
		Console.WriteLine("\n===Matriz de Medição===");
		Biblioteca.escreverMatriz(matrizMedicao);
		
		double cont=0, lagoasAdequadas=0;
		
		for(int i = 0; i<linhas; i++){
			for (int j = 0; j<cols; j++){
				if(matrizMedicao[i,j] > matrizReferencia[i,j]){
					cont ++;
				}
			}
			if(cont == 3){
					lagoasAdequadas++;
				}
			cont = 0;
		}
		
		Console.WriteLine($"Total de lagoas adequadas {lagoasAdequadas}");
		Console.WriteLine($"Percentual de lagoas adequadas {(lagoasAdequadas/linhas)*100:F2}");
		
	
	}
}