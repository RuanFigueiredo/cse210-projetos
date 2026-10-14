using System;

public class MetaDeListaDeTarefas : Meta
{
    //atributos
    private int _concluidas;
    private int _total;
    private int _bonus;

    //construtor
    public MetaDeListaDeTarefas(string nome, string descricao, string pontos,int total, int bonus) : base(nome, descricao, pontos)
    {
        
    }

    // métodos
    public override void RegistrarEvento()
    {
        throw new NotImplementedException();
    }

    public override bool EstaConcluida()
    {
        throw new NotImplementedException();
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