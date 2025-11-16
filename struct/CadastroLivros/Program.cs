using System;
class Program
{

    static int menu()
    {
        int opcao = 0;

        Console.WriteLine("--- Menu de opções ---");
        Console.WriteLine("1 - Cadastro de livros");
        Console.WriteLine("2 - Procura de livro por nome");
        Console.WriteLine("3 - Exibir todos os livros cadastrados");
        Console.WriteLine("4 - Procura de livros por ano");
        Console.WriteLine("0 - Sair do sistema");

        Console.WriteLine("Digite a opção escolhida: ");




        return opcao;
    }
    static void Main()
    {
        List<Livros> listaLivros = new List<Livros>();

        int opcao = 0;

        Console.WriteLine("====== BIBLIOTECA ======");

        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Teste ok");
                    break;

                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
            }
        } while (opcao != 0);


    }
}