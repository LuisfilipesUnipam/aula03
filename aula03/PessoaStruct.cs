public struct PessoaStruct {
    private string nomeStruct = "";

    public string NomeStruct {
        get { return nomeStruct; }
        set { NomeStruct = value; }
    }

    public PessoaStruct(string nomeStruct){
        NomeStruct = nomeStruct;
    }

    public override string ToString(){
        return $"Nome: {NomeStruct}";
    }
}