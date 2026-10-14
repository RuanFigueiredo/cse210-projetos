using System;
using System.Collections.Generic;

//classe abstract Meta(Classe base)
public abstract class Meta
{
    protected string _nome;
    protected string _descricao;
    protected string _pontos;
    
    //construtor
    public Meta(string nome, string descricao, string pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    //métodos
    public abstract void  RegistrarEvento();

    public abstract bool EstaConcluida();

    public virtual string ObterDetalhesEmTexto()
    {
        return $"{_nome} - {_descricao} - {_pontos} pontos";
    }

    public abstract string ObterRepresentacaoEmTexto();

}