public class AtividadeDeRespiracao : Atividade
{
    //construtor da classe AtividadeDeRespiracao que chama o construtor da classe base Atividade
    public AtividadeDeRespiracao(string nome, string descricao) : base(nome, descricao)
    {
        
    }

    //métodos
public void Executar()
    {
        ExibirMensagemInicial();
        Console.WriteLine("Respire fundo e relaxe...");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Inspire...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Expire...");
            System.Threading.Thread.Sleep(1000);
            ExibirProgresso(2);
        }
        ExibirMensagemFinal();
    }
}