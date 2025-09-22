using System;
using Biblioteca;
class Program
{
static void Main()
{
int n;
Console.Write("Entre com o tamanho do vetor: ");
n = int.Parse(Console.ReadLine());
int[] meuArray = new int[n];
BibliotecaVetor.gerarVetor(meuArray);
BibliotecaVetor.mostrarVetor(meuArray);
}
}