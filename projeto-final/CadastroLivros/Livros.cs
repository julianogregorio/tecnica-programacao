namespace CadastroLivros

{
    class Livro
    {
        public int id;
        public string isbn;
        public string name;
    }

    class Autor
    {
        public int id;
        public string name;
        public string nacao;
    }

    class Edicoes
    {
        public int id;
        public string editora;
        public int ano;
        public int num_edicao;
        public int id_livro;
    }

    class Lista
    {
        public int id;
        public int id_livro;
        public int id_autor;
    }

}