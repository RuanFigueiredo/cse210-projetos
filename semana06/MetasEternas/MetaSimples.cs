using System;
using System.Collections.Generic;

public class MetaSimples : Meta{
    private bool _estaConcluida;

    //construtor
    public MetaSimples(string nome, string descricao, string pontos) : base(nome, descricao, pontos)
    {
        _estaConcluida = false;
    }

    public override void RegistrarEvento()
    {
        
    }
    public override bool EstaConcluida()
    {
        return _estaConcluida;
    }

    public override string ObterDetalhesEmTexto()
    {
        throw new NotImplementedException();
    }

    public override string ObterRepresentacaoEmTexto()
    {
        throw new NotImplementedException();
    }
}


    
       


