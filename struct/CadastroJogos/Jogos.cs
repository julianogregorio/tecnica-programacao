namespace CadastroJogos

{
    class Emprestimo {
        public DateTime data;
        public string nomePessoa;
        public char emprestado; 
    }

    class Jogos {
        public string titulo;
        public string console;
        public int ano;
        public int ranking;

        public Emprestimo emprestimo;  
    }
}
