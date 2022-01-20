class Livro{
    public int Id {get; set;}
    public sring Titulo {get; set;}
    public double Preco {get; set;}
    public Autor Autor {get; set;}
}

class Autor
    {
        public string Nome {get; set;}
        public string Email {get; set;}
    }

static void Main(string[] args)
    {
        Livro livro = new Livro();
        //criando uma instância da classe Livro
        livro.Preco = 10;
        Console.WriteLine(livro.Preco);

}