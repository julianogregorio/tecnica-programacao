using System;

namespace CadastroEletro{

    static void addEletro(List<Eletro> lista){

        Eletro novoEletro = new Eletro();
        Console.Write("Entre com o nome: ");
        novoEletro.nome = Console.ReadLine();  
        
        Console.Write("Entre com a potência: ");
        novoEletro.potencia = double.Parse(Console.ReadLine());  
        
        Console.Write("Entre com o tempo médio de uso diário: ");
        novoEletro.tempoMedioUsoDiario = double.Parse(Console.ReadLine());

        listaEletros.add(novoEletro);  

    }
    
    
    static void Main(){
        List <Eletro> listaEletros = new list <Eletro>();
    }


}