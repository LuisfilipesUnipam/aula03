public class Program{
    public static void Main(){
        Cliente cliente01 = new Cliente(1, "João");
        Cliente cliente02 = new Cliente(2, "Maria");

        Produto produto01 = new Produto(1, "Notebook", 3500.00M);
        Produto produto02 = new Produto(2, "SmartPhone", 1800.00M);
        Produto produto03 = new Produto(3, "Tablet", 1200.00M);
        Produto produto04 = new Produto(4, "Fone de Ouvido", 150.00M);

        Compra compra01 = new Compra(cliente01);
        compra01.AdicionarProdutos(produto01);
        compra01.AdicionarProdutos(produto02);
        compra01.AdicionarProdutos(produto04);

        Compra compra02 = new Compra(cliente02);
        compra02.AdicionarProdutos(produto01);
        compra02.AdicionarProdutos(produto03);
        compra02.AdicionarProdutos(produto02);

        Console.WriteLine(compra01);
        Console.WriteLine(compra02);
    }
}