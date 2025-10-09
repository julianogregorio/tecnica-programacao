using System;

class Exercicio2{

static bool verificarNome(string [] vetor){
	
	Console.WriteLine("Entre com nome a ser pesquisado: ");
	string nomeVerificar = Console.ReadLine();
	
	for(int i= 0; i<vetor.Length; i++){
		if(vetor[i].ToUpper() == nomeVerificar.ToUpper()){
			return true;
		}
	}
	
	return false;
	
}

static void Main(){
	
Console.WriteLine("Entre com a quantidade de nome que serão inseridos");
int quant = int.Parse(Console.ReadLine());

string [] vetor = new string [quant];

for(int i = 0; i<quant; i++){
	Console.WriteLine($"Digite o {i+1}º nome: ");
	vetor [i] = Console.ReadLine();
}



if(verificarNome(vetor)){
	Console.WriteLine("\nNome já cadastrado!");
}else{
	Console.WriteLine("\nNome não cadastrado!");
}



}
}