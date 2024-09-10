public class Cliente{

    private int id;
    private string nome;

    public int Id{
        get { return id; }
        set { id = value; }
    }

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }

    public Cliente(long id, string nome){
        Id = id;
        Nome = nome;
    }

    public override ToString(){
        return $"Id: {Id}, Nome: {Nome}";
    }
}