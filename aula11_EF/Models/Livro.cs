namespace aula11_EF.Models{
    public class Livro{
        public int Id {get; set;}
        public string Nome {get; set;}
        public decimal Preco {get; set;}

        public Livro(string nome, decimal preco){
            Nome = nome;
            Preco = preco;
        }

        public override string ToString(){
            return $"Titulo: {Nome}, Preço: {Preco:c}";
        }
    }
}