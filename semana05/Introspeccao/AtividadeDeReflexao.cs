public class AtividadeDeReflexao : Atividade
{
    //Atributos
    private List<string> _perguntas;
    private List<string> _reflexoes;
    //construtor da classe AtividadeDeReflexao
    public AtividadeDeReflexao(string nome, string descricao) : base(nome, descricao)
    {
        _perguntas = new List<string>
        {
            "Pense em um momento em que você se sentiu orgulhoso de si mesmo. O que aconteceu?",
            "Pense em uma situação em que você ajudou alguém. Como isso fez você se sentir?",
            "Pense em um desafio que você superou recentemente. O que você aprendeu com isso?",
            "Pense em uma pessoa que teve um impacto positivo em sua vida. O que essa pessoa fez por você?",
            "Pense em algo que você gostaria de melhorar em si mesmo. O que você pode fazer para alcançar isso?"
        };
        _reflexoes = new List<string>();
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
    //getter para reflexoes
    public List<string> ObterReflexoes()
    {
        return _reflexoes;
    }  
    //setter para reflexoes
    public void DefinirReflexoes(List<string> reflexoes)
    {
        _reflexoes = reflexoes;
    }
    //método para executar a atividade de reflexão
    public void Executar()
    {
        ExibirMensagemInicial();
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        string pergunta = _perguntas[index];
        Console.WriteLine(pergunta);
        Console.WriteLine("Você tem 30 segundos para refletir sobre essa pergunta. Pressione Enter quando terminar.");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < 30)
        {
            string reflexao = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(reflexao))
            {
                _reflexoes.Add(reflexao);
            }
        }
        ExibirMensagemFinal();
    }
    //método para obterReflexões aleatorias
    public List<string> ObterReflexoesAleatorias(int quantidade)
    {
        List<string> reflexoesAleatorias = new List<string>();
        Random random = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            int index = random.Next(_reflexoes.Count);
            reflexoesAleatorias.Add(_reflexoes[index]);
        }
        return reflexoesAleatorias;
    }
    // método para obter perguntas aleatorias
    public List<string> ObterPerguntasAleatorias(int quantidade)
    {
        List<string> perguntasAleatorias = new List<string>();
        Random random = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            int index = random.Next(_perguntas.Count);
            perguntasAleatorias.Add(_perguntas[index]);
        }
        return perguntasAleatorias;
    }
    // métodos para exibir reflexões aleatórias
    public void ExibirReflexoesAleatorias(int quantidade)
    {
        List<string> reflexoesAleatorias = ObterReflexoesAleatorias(quantidade);
        Console.WriteLine("Reflexões aleatórias:");
        foreach (string reflexao in reflexoesAleatorias)
        {
            Console.WriteLine(reflexao);
        }
    }
    // métodos para exibir perguntas aleatórias
    public void ExibirPerguntasAleatorias(int quantidade)
    {
        List<string> perguntasAleatorias = ObterPerguntasAleatorias(quantidade);
        Console.WriteLine("Perguntas aleatórias:");
        foreach (string pergunta in perguntasAleatorias)
        {
            Console.WriteLine(pergunta);
        }
    }
}