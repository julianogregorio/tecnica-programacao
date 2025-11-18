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


                novoJogo.emprestimo.data = DateTime.Now;
                Console.Write($"Data do empréstimo: {novoJogo.emprestimo.data:dd/MM/yyyy}");

            }


            listaJogos.Add(novoJogo);

            Console.WriteLine("\nJogo cadastrado com sucesso!");
            Console.WriteLine("--------------------------");
        }

        static void buscarTituloConsole(List<Jogos> listaJogos)
        {

            bool encontrado = false;

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("Digite o título ou console que você deseja buscar: ");

            string busca = Console.ReadLine();





            foreach (Jogos j in listaJogos)
            {

                if (j.titulo.ToLower().Contains(busca) || j.console.ToLower().Contains(busca))
                {
                    Console.WriteLine($"\n** Jogo **");
                    Console.WriteLine($"Título: {j.titulo}");
                    Console.WriteLine($"Console: {j.console}");
                    Console.WriteLine($"Ano: {j.ano}");
                    Console.WriteLine($"Ranking: {j.ranking}");

                    if (j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
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
        static void emprestarJogo(List<Jogos> listaJogos)
        {

            bool encontrado = false;

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("Digite o título para realizar o empréstimo: ");

            string busca = Console.ReadLine();





            foreach (Jogos j in listaJogos)
            {

                if (j.titulo.ToLower() == busca.ToLower())
                {
                    Console.WriteLine($"\n** Jogo **");
                    Console.WriteLine($"Título: {j.titulo}");
                    Console.WriteLine($"Console: {j.console}");
                    Console.WriteLine($"Ano: {j.ano}");
                    Console.WriteLine($"Ranking: {j.ranking}");

                    if (j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
                    {
                        Console.WriteLine("Jogo emprestado!");
                        Console.WriteLine("Não é possível realizar o empréstimo.");
                    }
                    else
                    {
                        Console.WriteLine("Jogo disponível!");
                        Console.Write("Realizar o empréstimo? (S/N): ");
                        char opcao = char.Parse(Console.ReadLine().ToUpper());
                        if (opcao == 'S')
                        {
                            j.emprestimo.emprestado = 'S';
                            Console.Write("Nome da pessoa: ");
                            j.emprestimo.nomePessoa = Console.ReadLine();
                            j.emprestimo.data = DateTime.Now;
                            Console.WriteLine($"Data do empréstimo: {j.emprestimo.data:dd/MM/yyyy}");
                            Console.WriteLine("Empréstimo realizado com sucesso!");
                        }
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
        static void devolverJogo(List<Jogos> listaJogos)
        {

            bool encontrado = false;

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("Digite o título para realizar a devolução: ");

            string busca = Console.ReadLine();





            foreach (Jogos j in listaJogos)
            {

                if (j.titulo.ToLower() == busca.ToLower())
                {
                    Console.WriteLine($"\n** Jogo **");
                    Console.WriteLine($"Título: {j.titulo}");
                    Console.WriteLine($"Console: {j.console}");
                    Console.WriteLine($"Ano: {j.ano}");
                    Console.WriteLine($"Ranking: {j.ranking}");

                    if (j.emprestimo.emprestado == 'N' || j.emprestimo.emprestado == 'n')
                    {
                        Console.WriteLine("Jogo disponível!");
                        Console.WriteLine("Não é possível realizar a devolução.");
                    }
                    else
                    {
                        Console.WriteLine($"Jogo emprestado para: {j.emprestimo.nomePessoa}");
                        Console.WriteLine($"Data do empréstimo: {j.emprestimo.data:dd/MM/yyyy}");
                        Console.Write("Realizar o empréstimo? (S/N): ");
                        char opcao = char.Parse(Console.ReadLine().ToUpper());
                        if (opcao == 'S')
                        {
                            j.emprestimo.emprestado = 'n';
                            j.emprestimo.nomePessoa = "";
                            j.emprestimo.data = DateTime.Now;
                            Console.WriteLine("Devolução realizada com sucesso!");
                        }
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

                if (j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
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
        static void exibirEmprestimos(List<Jogos> listaJogos)
        {
            bool flag = false;
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("--- Jogos Emprestados ---");

            foreach (Jogos j in listaJogos)
            {


                if (j.emprestimo.emprestado == 'S' || j.emprestimo.emprestado == 's')
                {

                    Console.WriteLine($"Título: {j.titulo}");
                    Console.WriteLine($"Console: {j.console}");
                    Console.WriteLine($"Ano: {j.ano}");
                    Console.WriteLine($"Ranking: {j.ranking}");
                    Console.WriteLine($"Título emprestado para: {j.emprestimo.nomePessoa}");
                    Console.WriteLine($"Data do empréstimo: {j.emprestimo.data:dd/MM/yyyy}");

                    flag = true;



                }


                Console.WriteLine("--------------------------");

            }

            if (!flag)
                {
                    Console.WriteLine("Nenhum jogo emprestado.");
                    Console.WriteLine("--------------------------");
                }

        }

        static int menu()
        {
            int opcao = 0;

            Console.WriteLine("\n--- Menu de opções ---");
            Console.WriteLine("1 - Cadastrar jogos");
            Console.WriteLine("2 - Procurar titulo ou  por console");
            Console.WriteLine("3 - Exibir todos os jogos cadastrados");
            Console.WriteLine("4 - Realizar empréstimo de jogo");
            Console.WriteLine("5 - Realizar devolução de jogo");
            Console.WriteLine("6 - Exibir empréstimos ativos");
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

                    case 4:
                        emprestarJogo(listaJogos);
                        break;

                    case 5:
                        devolverJogo(listaJogos);
                        break;

                    case 6:
                        exibirEmprestimos(listaJogos);
                        break;


                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }
            } while (opcao != 0);


        }
    }

}