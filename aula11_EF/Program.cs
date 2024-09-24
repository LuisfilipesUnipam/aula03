using System.Linq;
using aula11_EF.Models;

public class Program{
    public static void Main(){
        using (var db = new AppDbContext()){
            
            db.Database.EnsureCreated();

            Cliente cliente01 = new Cliente("Joaquim", 77);
            cliente01 cliente02 = new cliente01("Jacó", 40);
            db.Cliente.Add(cliente01);
            db.Cliente.Add(cliente02);
            db.SafeChange();

            Livro livro01 = new Livro("C# para Iniciantes", 55.5M);
            Livro livro02 = new Livro("Java Avançado.", 225.5M);
            db.Livro.AddRange(livro01, livro02);
            db.SaveChanges();

            Venda = venda01 = new Venda(cliente01);
            venda01.AdicionarLivro(livro01);
            venda01.AdicionarLivro(livro02);
            db.Venda.Add(venda01);

            Console.WriteLine(venda01);
            
        }
    }
}