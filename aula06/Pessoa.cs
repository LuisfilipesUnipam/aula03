public class Pessoa {
    private string nome;
    private double nota;

    public Pessoa(string nome, int nota){
        Nome = nome;
        Nota = nota;
    }

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }

    public double Nota{
        get { return nota; }
        set { nota = value; }
    }

}