using System;
using System.Collections.Generic;

public class GerenciadorDeMetas
{       
    //Variaveis membros    
    private List<Meta> _metas;
    private int _pontos;

   //construtor
   public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    //métodos
    public void Iniciar()
    {
            int opcao = 0;

        while (opcao != 6)
        {
            //Exibe os pontos do jogador no topo de cada ciclo do loop while
            ExibirInfoJogador();

            Console.WriteLine("\nOpções do Menu:");
            Console.WriteLine("1. Criar Nova Meta");
            Console.WriteLine("2. Listar Metas");
            Console.WriteLine("3. Salvar Metas");
            Console.WriteLine("4. Carregar Metas");
            Console.WriteLine("5. Registrar Evento");
            Console.WriteLine("6. Sair");

            Console.WriteLine("Selecione uma opção do menu: ");

            //Validação de entrada do usuário
            if(int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CriarMeta();
                        break;
                    case 2:
                        ListarNomesDasMetas();
                        break;
                    case 3:
                        SalvarMetas();
                        break;
                    case 4:
                        CarregarMetas();
                        break;
                    case 5:
                        RegistrarEvento();
                        break;
                    case 6:
                        Console.WriteLine("a encerrar o programa...");
                        break;
                    default:
                        Console.WriteLine("opção inválida. Escolha um número de 1 a 6");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Por favor digite apenas números válidos");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"\n===================================");
        Console.WriteLine($"Pontuação Atual: {_pontos} pontos");
        Console.WriteLine($"\n===================================");

    }

    public void ListarNomesDasMetas()
    {
        Console.WriteLine("\nAs Metas são:");
        for(int i = 0;i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("\nAS Metas são:");

        if(_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada ainda.");
            return;
        }
        for ( int i = 0; i < _metas.Count; i ++)
        {
            Meta meta = _metas[i];
            string status = meta.EstaConcluida() ? "[X]" : "[ ]"; 

            Console.WriteLine($"{i+1}. {status} {meta.ObterDetalhesEmTexto()} ");
        }

    }

    public void CriarMeta()
    {
       Console.WriteLine("\nOs tipos de metas são: ");
       Console.WriteLine("1. Meta Simples");
       Console.WriteLine("2. MEta Eterna");
       Console.WriteLine("3. MEta de lista de Tarefas");
       Console.WriteLine("\nQual tipo de meta você gostaria de criar?");

       //validação de entrada do usuário
       if(int.TryParse(Console.ReadLine(),out int tipo))
        {
            Console.WriteLine("Qual é o nome da sua meta? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a descrição abreviada da sua meta?");
            string descricao = Console.ReadLine();

            Console.WriteLine("Qual é a quantidade de pontos associada a essa meta?");
            string pontos = Console.ReadLine();

            Meta novaMeta = null;

            switch (tipo)
            {
                case 1:
                    novaMeta = new MetaSimples(nome, descricao,pontos);
                    break;
                case 2:
                    novaMeta = new MetaEterna(nome,descricao, pontos);
                    break;
                case 3:
                    Console.WriteLine("Quantas vezes essa meta precisa ser concluída para receber um bônus?");
                    int total = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual é o bônus por concluí-la esse número de vezes?");
                    int bonus = int.Parse(Console.ReadLine());

                    novaMeta = new MetaDeListaDeTarefas(nome,descricao, pontos, total, bonus);
                    break;
                default:
                Console.WriteLine("opção inválida. EScolha um número de 1 a 3.");
                break;
            }
            if (novaMeta != null)
            {
                _metas.Add(novaMeta);
                Console.WriteLine("Meta criada com sucesso!");
            }
        }
        else
        {
            Console.WriteLine("por favor, digite números válidos");
        }
    }

    public void RegistrarEvento()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("\nNão há metas cadastradas para registrar.");
            return;
        }

        ListarNomesDasMetas();
        Console.WriteLine("\nQual meta você realizou? (Digite o número correspondente): ");

        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= _metas.Count)
        {
            Meta metaSelecionada = _metas[indice - 1];
            
            metaSelecionada.RegistrarEvento();
        
            Console.WriteLine("\nParabéns! Evento registrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Número de meta inválido.");
        }
    }

    public void SalvarMetas()
    {
        Console.WriteLine("Qual é o nome do arquivo para salvar as metas? (Ex: metas.txt): ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(nomeArquivo))
        {
            outputFile.WriteLine(_pontos);

            foreach (Meta meta in _metas)
            {
                outputFile.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }

        Console.WriteLine("Metas salvas com sucesso!");
    }
  
    public void CarregarMetas()
    {
        Console.WriteLine("Qual é o nome do arquivo de onde deseja carregar as metas? (Ex: metas.txt): ");
        string nomeArquivo = Console.ReadLine();

        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);

            _pontos = int.Parse(linhas[0]);

            _metas.Clear(); 
            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                string[] partes = linha.Split(":");
                string tipoMeta = partes[0];
                string detalhes = partes[1];

                string[] dados = detalhes.Split(",");

                if (tipoMeta == "MetaSimples")
                {
                    // Exemplo de reconstrução (ajuste conforme os construtores das suas classes)
                    // string nome = dados[0], descricao = dados[1], pontos = dados[2];
                    // bool concluida = bool.Parse(dados[3]);
                    // MetaSimples meta = new MetaSimples(nome, descricao, pontos, concluida);
                    // _metas.Add(meta);
                }
                else if (tipoMeta == "MetaEterna")
                {
                    // Lógica para MetaEterna
                }
                else if (tipoMeta == "MetaDeListaDeTarefas")
                {
                    // Lógica para MetaDeListaDeTarefas
                }
            }

            Console.WriteLine("Metas carregadas com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
