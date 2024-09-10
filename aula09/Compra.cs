using System.List;
public class Compra{
    public Cliente Cliente { get; set;}
    public List<Produto> Produto { get; set;}

    public Compra(Cliente cliente){
        Cliente = cliente;
        Produtos = new List<Produto>();
    }

    public void AdicionarProdutos(Produto produto){
        Produtos.Add(produto);
    }

    public decimal CalcularTotal(){
        return Produtos.Sum(p => p.Preco);
    } 

    public override string ToString(){
        string produtoStr = string.Join(", ", Produtos.Select(p => p.Nome));
        return $"Compra de {Cliente.Nome}, Produtos: [{produtoStr}], Total: {CalcularTotal():C}";
    }

}