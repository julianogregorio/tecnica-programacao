using System;

namespace CadastroLivros
{
    class Program
    {

        static void addLivros(List<Livros> listaLivros)
        {
            Console.WriteLine("\n--------------------------");

            Livros novoLivro = new Livros();

            Console.WriteLine("--- Cadastro de Livros ---");

            Console.WriteLine("\nDigite o título do livro: ");
            novoLivro.titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor do livro: ");
            novoLivro.autor = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação do livro: ");
            novoLivro.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a prateleira onde o livro será armazenado: ");
            novoLivro.prateleira = Console.ReadLine();

            listaLivros.Add(novoLivro);


            Console.WriteLine("\nLivro cadastrado com sucesso!");

            Console.WriteLine("--------------------------");
        }
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


        static int menu()
        {
            int opcao = 0;

            Console.WriteLine("\n--- Menu de opções ---");
            Console.WriteLine("1 - Cadastrar livros");
            Console.WriteLine("2 - Procurar livro por nome");
            Console.WriteLine("3 - Exibir todos os livros cadastrados");
            Console.WriteLine("4 - Procurar livros por ano");
            Console.WriteLine("0 - Sair do sistema");

            Console.WriteLine("\nDigite a opção escolhida: ");
            opcao = int.Parse(Console.ReadLine());




            return opcao;
        }
        static void Main()
        {
            List<Livros> listaLivros = new List<Livros>();

            int opcao = 0;

            Console.WriteLine("\n====== BIBLIOTECA ======");

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        addLivros(listaLivros);
                        break;


                    case 2:
                        buscarTitulo(listaLivros);
                        break;

                    case 3:
                        exibirLivros(listaLivros);
                        break;

                    case 4:
                        buscarAno(listaLivros);
                        break;


                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }
            } while (opcao != 0);


        }
    }

}