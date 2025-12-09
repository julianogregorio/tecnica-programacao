using System;
namespace MatrizGrafo
{
    class Program
    {
        static void imprimirMatriz(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    System.Console.Write(matriz[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }

        static int Menu()
        {

            Console.WriteLine("===== ATIVIDADE DE MATEMÁTICA DISCRETA ====== ");
            Console.WriteLine("=== Menu de Opções: === ");

            Console.WriteLine("1. Adicionar Aresta");
            Console.WriteLine("2. Remover Aresta");
            Console.WriteLine("3. Mostrar Matriz");
            Console.WriteLine("4. Verificar Propriedades");
            Console.WriteLine("5. Matriz R Infinito");
            Console.WriteLine("6. Matriz de Conexividade");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
        static void Main(string[] args)
        {
            Grafo meuGrafo = new Grafo(10);
            meuGrafo.carregarMatrizDeArquivo("Juliano.txt");
            int opcao;

            do
            {
                opcao = Menu();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("*** Adicionar Aresta ***");
                        System.Console.Write("Digite o vértice de origem: ");
                        int origem = int.Parse(Console.ReadLine());
                        System.Console.Write("Digite o vértice de destino: ");
                        int destino = int.Parse(Console.ReadLine());
                        meuGrafo.adicionarAresta(origem, destino);
                        break;
                    case 2:
                        Console.WriteLine("*** Remover Aresta ***");
                        System.Console.Write("Digite o vértice de origem: ");
                        origem = int.Parse(Console.ReadLine());
                        System.Console.Write("Digite o vértice de destino: ");
                        destino = int.Parse(Console.ReadLine());
                        meuGrafo.removerAresta(origem, destino);
                        break;
                    case 3:
                        Console.WriteLine("*** Matriz de Adjacência ***");
                        meuGrafo.mostrarMatriz();
                        break;
                    case 4:
                        Console.WriteLine("*** Verificar Propriedades ***");

                        if (meuGrafo.eReflexiva())
                            Console.WriteLine("O grafo é reflexivo.");
                        else
                            Console.WriteLine("O grafo não é reflexivo.");

                        if (meuGrafo.eSimetrica())
                            Console.WriteLine("O grafo é simétrico.");
                        else
                            Console.WriteLine("O grafo não é simétrico.");

                        if (meuGrafo.verificarTransitividade())
                            Console.WriteLine("O grafo é transitivo.");
                        else
                            Console.WriteLine("O grafo não é transitivo.");
                        break;
                    case 5:
                        int[,] matrizRInfinito = meuGrafo.obterRInfinito();
                        Console.WriteLine("*** Matriz R Infinito ***");
                        imprimirMatriz(matrizRInfinito);
                        break;
                    case 6:
                        int[,] matrizConexividade = meuGrafo.obterMatrizConexividade();
                        Console.WriteLine("*** Matriz de Conexividade ***");
                        imprimirMatriz(matrizConexividade);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcao != 0);
        }
    }
}
