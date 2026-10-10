public class AtividadeDeListagem : Atividade
{
    //atributos
    private int _contador;
    private List<string> _perguntas;
    // construtor da classe AtividadeDeListagem
    public AtividadeDeListagem(string nome, string descricao) : base(nome, descricao)
    {
        _contador = 0;
        _perguntas = new List<string>
        {
            "Liste coisas pelas quais você é grato:",
            "Liste coisas que você gosta em si mesmo:",
            "Liste pessoas que você admira:",
            "Liste coisas que você deseja alcançar:",
            "Liste coisas que você aprendeu recentemente:"
        };
    } 

    //getter para contador
    public int ObterContador()
    {
        return _contador;
    }
    //setter para contador
    public void DefinirContador(int contador)
    {
        _contador = contador;
    }
    //getter para perguntas
    public List<string> ObterPerguntas()
    {
        return _perguntas;
    }
    //setter para perguntas
    public void DefinirPerguntas(List<string> perguntas)
    {
        _perguntas = perguntas;
    }

    //método para executar a atividade de listagem
    public void Executar()
    {
        ExibirMensagemInicial();
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        string pergunta = _perguntas[index];
        Console.WriteLine(pergunta);
        Console.WriteLine("Você tem 30 segundos para listar suas respostas. Pressione Enter quando terminar.");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < 30)
        {
            string resposta = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(resposta))
            {
                _contador++;
            }
        }
        ExibirMensagemFinal();
    }  
    //método para obter as perguntas aleatórias da lista
    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        string pergunta = _perguntas[index];
        Console.WriteLine(pergunta);
    }
    public List<string> ObterListaDoUsuario()
    {
        List<string> respostas = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < 30)
        {
            string resposta = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(resposta))
            {
                respostas.Add(resposta);
            }
        }
        return respostas;
    }


}