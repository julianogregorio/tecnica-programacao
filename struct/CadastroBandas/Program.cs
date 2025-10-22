using System; 
namespace CadastroBandas
{
	class Program
	{
		
		static void addBandas (List<Banda> listaBandas)
		{
			
			Banda novaBanda = new Banda(); 
			
			Console.Write("\nNome da Banda: ");
			novaBanda.nome = Console.ReadLine();
			Console.Write("Genero: ");
			novaBanda.genero = Console.ReadLine();
			Console.Write("Número de integrantes: ");
			novaBanda.integrantes = int.Parse(Console.ReadLine());
			Console.Write("Ranking: ");
			novaBanda.ranking = int.Parse(Console.ReadLine());
			
			listaBandas.Add(novaBanda);
			
		}
		
		static void mostrarBandas (List<Banda> listaBandas)
		{
			
			int posicao = 1; 
			
			foreach(Banda b in listaBandas)
			{
				Console.WriteLine($"***Bandas {posicao}****");
				Console.WriteLine($"{b.nome} - {b.genero} - {b.integrantes} - {b.ranking}");
				posicao++;
			}
		}
		
		
		static int menu()
		{
			int opcao;
			
			Console.WriteLine("\n=== Sistema de Cadastro de Bandas ===");
			Console.WriteLine("1 - Adicionar Bandas");
			Console.WriteLine("2 - Mostrar Bandas");
			Console.WriteLine("0 - Sair do Sistema");
			Console.Write("Digite sua escolha: ");
			opcao = int.Parse(Console.ReadLine());
			
			return opcao;
		}
		
		
		
		static void Main()
		{
			List<Banda> listaBandas = new List<Banda>();
			
			int opcao = 0;
			
			do{
				opcao = menu();
				
				switch (opcao)
				{
					case 1:
					addBandas(listaBandas);
					break;
					
					case 2: 
					mostrarBandas(listaBandas);
					break;
					
					case 0:
					Console.WriteLine("Até mais");
					break;
					
				}
				
			Console.ReadKey(); //Pausa
			Console.Clear();//Limpa a tela
				
			}while (opcao != 0);
			
			
		}
	}
}