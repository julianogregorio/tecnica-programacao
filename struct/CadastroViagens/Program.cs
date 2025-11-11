using System; 

namespace CadastroViagens{
	
	class Program{
		
		static void addViagem(List<Viagens> listaViagens){
			
			Console.WriteLine("\n=== Cadastro de viagens ===");
			
			Viagens novaViagem = new Viagens ();
			
			Console.Write("Modelo do carro: ");
			novaViagem.modeloVeiculo = Console.ReadLine();
			Console.Write("Placa do carro: ");
			novaViagem.placa = Console.ReadLine();
			Console.Write("Destino da viagem: ");
			novaViagem.destino = Console.ReadLine();
			Console.Write("Distância (km) da viagem: ");
			novaViagem.kmViagem = float.Parse(Console.ReadLine());
			Console.Write("Consumo médio (km/L): ");
			novaViagem.consumoMedio = float.Parse(Console.ReadLine());
			
			listaViagens.Add(novaViagem);
		}
		
		static void exibirViagem (List<Viagens> listaViagens){
			Console.WriteLine("-----------------------------------------------");
			
			int posicao = 1;
			foreach(Viagens v in listaViagens){
				
				Console.WriteLine($"=== Viagem {posicao} ===");
				Console.WriteLine($"{v.modeloVeiculo} - {v.placa} - {v.destino} - {v.kmViagem} - {v.consumoMedio}");
				posicao++;
				
			}
			
			Console.WriteLine("-----------------------------------------------");
		}
		
		
		static void buscaPlaca (List<Viagens> listaViagens){
			
			string placaBuscada;
			
			Console.WriteLine("-----------------------------------------------");
			
			Console.WriteLine("=== Busca pela placa ===");
			
			Console.WriteLine("Informe a placa do veículo: ");
			placaBuscada = Console.ReadLine();
			
			int posicao = 1;
			foreach(Viagens v in listaViagens){
				
				if(v.placa.ToUpper().Contains(placaBuscada.ToUpper())){
					Console.WriteLine("-----------------------------------------------");
					Console.WriteLine($"=== Dados da viagem ===");
					Console.WriteLine($"{v.modeloVeiculo} - {v.placa} - {v.destino} - {v.kmViagem} - {v.consumoMedio}");
				}else{
					Console.WriteLine("-----------------------------------------------");
					Console.WriteLine("Dados não encontrados");
				}
				
			}
			
			Console.WriteLine("-----------------------------------------------");
		}
		
		
		static void buscaConsumo (List<Viagens> listaViagens){
			
			float limiteConsumo;
			bool encontrado = false;
			
			Console.WriteLine("-----------------------------------------------");
			
			Console.WriteLine("=== Busca pelo consumo ===");
			
			
			Console.WriteLine("Informe o limite de consumo da viagem: ");
			limiteConsumo = float.Parse(Console.ReadLine());
			
			
			
			int posicao = 1;
			foreach(Viagens v in listaViagens){
				
				if(v.consumoMedio >= limiteConsumo){
					Console.WriteLine("-----------------------------------------------");
					Console.WriteLine($"=== Dados da viagem ===");
					Console.WriteLine($"{v.modeloVeiculo} - {v.placa} - {v.destino} - {v.kmViagem} - {v.consumoMedio}");
					encontrado = true;
				}
			}
			
			if(encontrado == false){
				Console.WriteLine("-----------------------------------------------");
				Console.WriteLine("Dados não encontrados");
			}
			
			Console.WriteLine("-----------------------------------------------");
		}
		
		
		static int menu(){
			int opcao;
			Console.WriteLine("=== Menu de opções ===");

			Console.WriteLine("1 - Cadastrar novas viagens");
			Console.WriteLine("2 - Exibir viagens cadastradas");
			Console.WriteLine("3 - Buscar viagens pela placa");
			Console.WriteLine("4 - Buscar viagens pelo consumo");
			Console.WriteLine("5 - Gasto total para cada viagem");



			Console.WriteLine("0 - Sair");
			
			Console.WriteLine("Digite a opção escolhida: ");
			opcao = int.Parse(Console.ReadLine());
			
			



			return opcao;
			
		}
		
		static void Main(){
			
			List<Viagens> listaViagens = new List<Viagens>();
			int opcao;
			
			do{
				
				opcao = menu();
				
				switch (opcao){
					case 1:
					addViagem(listaViagens); 
					break;
					
					case 2:
					exibirViagem(listaViagens); 
					break;
					
					case 3:
					buscaPlaca(listaViagens); 
					break;
					
					case 4:
					buscaConsumo(listaViagens); 
					break;
					
					case 0:
					Console.WriteLine("Saindo...");
					break;

				}
				
			}while(opcao !=0);
			
		}
	}
}