using System;
using System.Runtime.InteropServices;

namespace CadastroEletro
{

    class Program
    {
           
        static void addEletro(List<Eletro> listaEletros)
        {

            Console.WriteLine("\n=====NOVO CADASTRO=====");

            Eletro novoEletro = new Eletro();
            Console.Write("Entre com o nome: ");
            novoEletro.nome = Console.ReadLine();

            Console.Write("Entre com a potência: ");
            novoEletro.potencia = double.Parse(Console.ReadLine());

            Console.Write("Entre com o tempo médio de uso diário: ");
            novoEletro.tempoMedioUsoDiario = double.Parse(Console.ReadLine());

            listaEletros.Add(novoEletro);

            Console.WriteLine("-------------------------");

        }

        static void mostrarEletro(List<Eletro> listaEletros)
        {

            int posicao = 1;

            Console.WriteLine("\n=====ELETRÔNICOS CADASTRADOS=====");

            foreach (Eletro e in listaEletros)
            {
                Console.WriteLine($"\n***Eletrodoméstico {posicao}****");
                Console.WriteLine($"{e.nome} - {e.potencia} - {e.tempoMedioUsoDiario}");
                posicao++;
            }
            Console.WriteLine("\n-------------------------");
        }

        static bool buscarEletros(List<Eletro> listaEletros, string nomeBusca)
        {

            foreach (Eletro e in listaEletros)
            {
                if (e.nome.ToUpper().Contains(nomeBusca.ToUpper()))
                {
                    Console.WriteLine("\n===Dados do eletrodoméstico===");
                    Console.WriteLine($"Nome da eletrodoméstico: {e.nome}");
                    Console.WriteLine($"Potência: {e.potencia}");
                    Console.WriteLine($"Tempo médio de uso diário: {e.tempoMedioUsoDiario}");
                    Console.WriteLine("\n-------------------------");
                    return true;
                }
            }
            return false;
        }
        
        
        
        static int buscarIndiceEletro(List<Eletro> listaEletros, string nomeEletro)
		{

			for (int i = 0; i < listaEletros.Count; i++)
			{
				if (listaEletros[i].nome.ToUpper().Equals(nomeEletro.ToUpper()))
				{

					return i;
				}
			}
			return -1;
		}



        static bool atualizarEletro(List<Eletro> listaEletros, string nomeEletro)
        {
            int i = buscarIndiceEletro(listaEletros, nomeEletro);
            if (i == -1)

                return false;
            Console.WriteLine("\n===Dados do eletrodoméstico===");
            Console.WriteLine($"{listaEletros[i].nome} - {listaEletros[i].potencia} - {listaEletros[i].tempoMedioUsoDiario}");
            Console.WriteLine("\n----Novos dados----");
            Console.Write("Nome: ");
            listaEletros[i].nome = Console.ReadLine();
            Console.Write("Potência: ");
            listaEletros[i].potencia = double.Parse(Console.ReadLine());
            Console.Write("Tempo médio de uso diário: ");
            listaEletros[i].tempoMedioUsoDiario = double.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------------------");
            return true;

        }

        static bool removerEletro(List<Eletro> listaEletros, string nomeEletro)
        {
            int i = buscarIndiceEletro(listaEletros, nomeEletro);
            if (i == -1)

                return false;
            Console.Write($"Tem certeza que deseja excluir {nomeEletro} [1 - Sim | 2 - Não]: ");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
                listaEletros.RemoveAt(i);
            Console.Write("Eletrodoméstico removido com sucesso!");
            Console.WriteLine("\n-------------------------");
            return true;

        }

        static void salvarDados(List<Eletro> listaEletros, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Eletro e in listaEletros)
                {
                    writer.WriteLine($"{e.nome},{e.potencia},{e.tempoMedioUsoDiario}");
                }
            }
            Console.WriteLine("Dados salvos com sucesso!");
        }
        
        static void carregarDados(List<Eletro> listaEletros, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(',');
                    Eletro novoEletro = new Eletro();
                    novoEletro.nome = campos[0];
                    novoEletro.potencia = double.Parse(campos[1]);
                    novoEletro.tempoMedioUsoDiario = double.Parse(campos[2]);
                    listaEletros.Add(novoEletro);
                }
                Console.WriteLine("\nDados carregados com sucesso!");
            }
            else
                Console.WriteLine("\nArquivo não encontrado :(");

        }


        static int menu()
        {
            int opcao;

            Console.WriteLine("\n=== Sistema de Cadastro de Eletrodoméstico ===");
            Console.WriteLine("1 - Adicionar Eletros");
            Console.WriteLine("2 - Mostrar Eletros");
            Console.WriteLine("3 - Buscar Eletros");
            Console.WriteLine("4 - Atualizar Eletros");
            Console.WriteLine("5 - Remover Eletros");
            Console.WriteLine("0 - Sair do Sistema");
            Console.Write("Digite sua escolha: ");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }
    
        static void Main()
        {
            List<Eletro> listaEletros = new List<Eletro>();

            int opcao = 0;
            
            carregarDados(listaEletros, "eletros.txt");

            do
            {
                opcao = menu();

                switch (opcao)
                {   
                    case 1:
                    addEletro(listaEletros);
                    break;
                
                    case 2: 
                    mostrarEletro(listaEletros);
                    break;

                    case 3:
                    Console.WriteLine("\n=== Busca de eletrodoméstico ===");
                    Console.WriteLine("Nome do Eletrodoméstico: ");
                    string nomeEletro = Console.ReadLine();
                    bool encontrado = buscarEletros(listaEletros, nomeEletro);
                    if (!encontrado)
                        Console.WriteLine("Eletrodoméstico não encontrado");
                        Console.WriteLine("\n-------------------------");
                    break;

                    case 4:
                    Console.WriteLine("\n=== Atualizar cadastro de eletrodoméstico ===");
                    Console.WriteLine("Nome do eletrodoméstico para atualizar dados: ");
                    nomeEletro = Console.ReadLine();
                    encontrado = atualizarEletro(listaEletros, nomeEletro);
                    if (!encontrado)
                        Console.WriteLine("Eletrodoméstico não encontrado");
                        Console.WriteLine("\n-------------------------");
                    break;

                    case 5:
                    Console.WriteLine("\n=== Remover eletrodoméstico ===");
                    Console.WriteLine("Nome do eletrodoméstico para remover dados: ");
                    nomeEletro = Console.ReadLine();
                    encontrado = removerEletro(listaEletros, nomeEletro);
                    if (!encontrado)
                        Console.WriteLine("Eletrodoméstico não encontrado");
                        Console.WriteLine("\n-------------------------");
                    break;
                    
                    case 0:
                    salvarDados(listaEletros, "eletros.txt");
                    Console.WriteLine("Até mais");
                    break;

                }

                Console.ReadKey(); //Pausa
                Console.Clear();//Limpa a tela

            } while (opcao != 0);



        }   


    }


}