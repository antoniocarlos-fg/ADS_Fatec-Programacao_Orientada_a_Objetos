public class Produto
{
    public int Codigo;
    public string Nome;
    public decimal preco;
    public decimal Preco
    {
        get => preco;
        set
        {
            if (value < 0)
                throw new ArgumentException("O valor não pode ser negativo.");
            preco = value;
        }
    }
    public int quantidadeEmEstoque;
    public int QuantidadeEmEstoque
    {
        get => quantidadeEmEstoque;
        set
        {
            if (value < 0)
                throw new ArgumentException("O valor não pode ser negativo.");
            quantidadeEmEstoque = value;
        }
    }

    public Produto(int Codigo, string Nome)
    {
        this.Codigo = Codigo;
        this.Nome = Nome;
        Preco = 0;
        QuantidadeEmEstoque = 0;
    }

    public Produto(int Codigo, string Nome, decimal Preco)
    {
        this.Codigo = Codigo;
        this.Nome = Nome;
        this.Preco = Preco;
        QuantidadeEmEstoque = 0;
    }

    public Produto(int Codigo, string Nome, decimal Preco, int QuantidadeEmEstoque)
    {
        this.Codigo = Codigo;
        this.Nome = Nome;
        this.Preco = Preco;
        this.QuantidadeEmEstoque = QuantidadeEmEstoque;
    }

    public void AdicionarEstoque(int qtd)
    {
        QuantidadeEmEstoque += qtd;
    }

    public void AdicionarEstoque(int qtd, string motivo)
    {
        QuantidadeEmEstoque += qtd;
        Console.WriteLine($"Motivo da adicao: {motivo}");
    }
}