using System;


public class MetaEterna : Meta
{
    //construtor
    public MetaEterna(string nome, string descricao, string pontos) : base(nome,descricao, pontos)
    {
        
    }

    public override bool EstaConcluida()
    {
        return false;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return "";
    }

    public override void RegistrarEvento()
    {
        throw new NotImplementedException();
    }


}