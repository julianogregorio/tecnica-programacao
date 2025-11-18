using System;

namespace CadastroJogos
{
    class Program
    {

        static void addJogos(List<Jogos> listaJogos)
        {
             Console.WriteLine("\n--------------------------");

            Jogos novoJogo = new Jogos();
            novoJogo.emprestimo = new Emprestimo();

            Console.WriteLine("--- Cadastro de Jogos ---");

            Console.Write("\nDigite o título do jogo: ");
            novoJogo.titulo = Console.ReadLine();

            Console.Write("Digite o nome do console: ");
            novoJogo.console = Console.ReadLine();

            Console.Write("Digite o ano do jogo: ");
            novoJogo.ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o ranking: ");
            novoJogo.ranking = int.Parse(Console.ReadLine());

            Console.Write("O jogo está emprestado? (S/N): ");
            novoJogo.emprestimo.emprestado = char.Parse(Console.ReadLine().ToUpper());

            if (novoJogo.emprestimo.emprestado == 'S')
            {
                Console.Write("Nome da pessoa: ");
                novoJogo.emprestimo.nomePessoa = Console.ReadLine();

                Console.Write("Data do empréstimo: ");
                novoJogo.emprestimo.data = Console.ReadLine();
            }

            
            listaJogos.Add(novoJogo);

            Console.WriteLine("\nJogo cadastrado com sucesso!");
            Console.WriteLine("--------------------------");
        }

        static void buscarTituloConsole(List<Jogos> listaJogos)
        {
            
            bool encontrado = false;

            Console.WriteLine("\n--------------------------");
            
            Console.WriteLine("Digite o título ou console que você desja buscar: ");

            string busca = Console.ReadLine();


            


            foreach (Jogos j in listaJogos)
            {
                
                if(j.titulo == busca || j.console == busca)
                {
                    Console.WriteLine($"\n** Jogo **");
                    Console.WriteLine($"Título: {j.titulo}");
                    Console.WriteLine($"Console: {j.console}");
                    Console.WriteLine($"Ano: {j.ano}");
                    Console.WriteLine($"Ranking: {j.ranking}");
                
                    if(j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
                    {
                        Console.WriteLine("Jogo emprestado!");
                    }
                    else
                    {
                        Console.WriteLine("Jogo disponível!");
                    }
                
                    Console.WriteLine("--------------------------");

                    encontrado = true;        

                }
                
                

            }

            if (!encontrado)
            {
                Console.WriteLine("Jogo não encontrado");
                Console.WriteLine("--------------------------");
            }

        }
        static void exibirJogos(List<Jogos> listaJogos)
        {
            int posicao = 1;
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("--- Jogos Cadastrados ---");

            foreach (Jogos j in listaJogos)
            {
                Console.WriteLine($"\n** Jogo {posicao}: **");
                Console.WriteLine($"Título: {j.titulo}");
                Console.WriteLine($"Console: {j.console}");
                Console.WriteLine($"Ano: {j.ano}");
                Console.WriteLine($"Ranking: {j.ranking}");
                
                if(j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
                {
                    Console.WriteLine("Jogo emprestado!");
                }
                else
                {
                    Console.WriteLine("Jogo disponível!");
                }
                
                posicao++;
                Console.WriteLine("--------------------------");

            }

        }
       
       /*
        static void buscarTitulo(List<Livros> listaLivros)
        {
            string tituloBuscado;

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("--- Buscar Título ---");

            Console.WriteLine("\nDigite o título do livro que deseja buscar: ");
            tituloBuscado = Console.ReadLine();

            foreach (Livros l in listaLivros)
            {
                if (l.titulo.ToLower().Contains(tituloBuscado.ToLower()))
                {
                    Console.WriteLine($"Título: {l.titulo}");

                    Console.WriteLine($"Prateleira: {l.prateleira}");
                    Console.WriteLine("--------------------------");
                }

            }
            Console.WriteLine("\nLivro não encontrado.");
            Console.WriteLine("--------------------------");
            return;
        }
        static void buscarAno(List<Livros> listaLivros)
        {
            bool encontrado = false;

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("--- Busca por ano de publicação ---");

            Console.WriteLine("\nDigite o ano limite para filtrar a busca: ");
            int anoLimite = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------");

            foreach (Livros l in listaLivros)
            {
                if (anoLimite <= l.ano)
                {
                    Console.WriteLine($"Título: {l.titulo}");
                    Console.WriteLine("--------------------------");
                    encontrado = true;
                }

            }

            if (!encontrado)
            {
                Console.WriteLine("\nNenhum livro encontrado para o ano informado.");
                Console.WriteLine("--------------------------");
            }


            return;
        }
        static void exibirLivros(List<Livros> listaLivros)
        {
            int posicao = 1;
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("--- Livros Cadastrados ---");

            foreach (Livros l in listaLivros)
            {
                Console.WriteLine($"\n** Livro {posicao}: **");
                Console.WriteLine($"Título: {l.titulo}");
                Console.WriteLine($"Autor: {l.autor}");
                Console.WriteLine($"Ano de publicação: {l.ano}");
                Console.WriteLine($"Prateleira: {l.prateleira}");
                posicao++;
                Console.WriteLine("--------------------------");

            }

        }

        */
        static int menu()
        {
            int opcao = 0;

            Console.WriteLine("\n--- Menu de opções ---");
            Console.WriteLine("1 - Cadastrar jogos");
            Console.WriteLine("2 - Procurar titulo ou  por console");
            Console.WriteLine("3 - Exibir todos os jogos cadastrados");
            Console.WriteLine("4 - Procurar livros por ano");
            Console.WriteLine("0 - Sair do sistema");

            Console.WriteLine("\nDigite a opção escolhida: ");
            opcao = int.Parse(Console.ReadLine());




            return opcao;
        }
        static void Main()
        {
            List<Jogos> listaJogos = new List<Jogos>();

            int opcao = 0;

            Console.WriteLine("\n====== COLEÇÃO DE JOGOS ======");

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        addJogos(listaJogos);
                        break;

                    
                   case 2:
                        buscarTituloConsole(listaJogos);
                        break;
            
                    case 3:
                        exibirJogos(listaJogos);
                        break;
                    /*    
                    case 4:
                        buscarAno(listaLivros);
                        break;

                    */
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }
            } while (opcao != 0);


        }
    }

}