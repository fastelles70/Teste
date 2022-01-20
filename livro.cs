class Livro{
    public int Id {get; set;}
    public String Titulo {get; set;}
    public Double Preco {get; set;}
}

static void Main(string[] args)
    {
        Livro livro = new Livro();
        //criando uma instância da classe Livro
        livro.Preco = 10;
        Console.writeLine(livro.Preco);

}