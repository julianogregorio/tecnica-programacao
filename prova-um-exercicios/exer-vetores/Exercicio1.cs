using System;

class Exercicio1{
	
	static bool existeStopCodon(string dna){
		
		dna = dna.ToUpper();
		
		for(int i = 0; i < dna.Length-2; i++){
		
			if(dna[i] == 'T' && dna[i+1] == 'A' && dna[i+2] == 'A'){
				return true;
			}
			
		} 
		
		return false;
		
	}
	
	static void Main(){
		
		Console.WriteLine("Entre com a sequência de DNA");
		
		string dna = Console.ReadLine();
		
		
		if(existeStopCodon(dna)==true){
			Console.WriteLine("A sequência contém");
		}else{
			Console.WriteLine("A sequência não contém");
		}
		
	}
}