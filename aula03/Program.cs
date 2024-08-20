class Program{
    public static void Main(string[] args){
        Pessoa objPessoa = new Pessoa("Matheus");
        Console.WriteLine("Antes do método (Classe): " + objPessoa.ToString());
        AlterarNomeClasse(objPessoa);
        Console.WriteLine("depois do método (Classe): " + objPessoa.ToString());

        PessoaStruct pessoaStruct = new PessoaStruct("Joao");
        Console.WriteLine("Antes do método (struct): " + pessoaStruct.ToString());
        AlterarNomeStruct(pessoaStruct);   
        Console.WriteLine("Depois do método (struct): " + pessoaStruct.ToString());
    }

    public static void AlterarNomeClasse(Pessoa objAux){
            objAux.Nome = "Danielly";
        }


    public static void AlterarNomeStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Maria";
    }

    
}