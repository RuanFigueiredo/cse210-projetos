public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0;
    }

    //setter para duração
    public void DefinirDuracao(int duracao)
    {
        _duracao = duracao;
    }
    //getter para duração
    public int ObterDuracao()
    {
        return _duracao;
    }
    
    //setter para nome
    public void DefinirNome(string nome)
    {
        _nome = nome;
    }
    //getter para nome
    public string ObterNome()
    {
        return _nome;
    }
    //setter para descrição
    public void DefinirDescricao(string descricao)
    {
        _descricao = descricao;
    }
    //getter para descrição
    public string ObterDescricao()
    {
        return _descricao;
    }
    //métodos para exibir mensagens
    public void ExibirMensagemInicial()
    {
        Console.WriteLine($"Atividade: {_nome}");
        Console.WriteLine($"Descrição: {_descricao}");
    }
    // método para exibir mensagem final
    public void ExibirMensagemFinal()
    {
        Console.WriteLine($"Duração da atividade: {_duracao} segundos");
    }
    // método para exibir progresso da atividade
    public void ExibirProgresso(int segundos)
    {
        _duracao += segundos;
        Console.WriteLine($"Progresso: {_duracao} segundos");
    }// método para exibir contagem regressiva
    public void ExibeContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo
        }
    }

}