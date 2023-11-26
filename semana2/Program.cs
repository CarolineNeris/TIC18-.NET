using System;
<<<<<<< HEAD
using app;

class Program
{
    static void Main(string[] args)
    {
        app.GerenciadorTarefas gerenciador = new app.GerenciadorTarefas();

        int opcao = 0;
        do
        {
            Console.WriteLine("------ Menu ------");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2.Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como concluída");
            Console.WriteLine("4. Listar tarefas pendentes");
            Console.WriteLine("5. Listar tarefas concluídas");
            Console.WriteLine("6. Excluir tarefa");
            Console.WriteLine("7. Pesquisar tarefas");
            Console.WriteLine("8. Estatisticas");
            Console.WriteLine("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o título da tarefa:");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Digite a descrição da tarefa:");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Digite a data de vencimento da tarefa (ano-mês-dia):");
                        DateTime dataVencimento;
                        DateTime.TryParse(Console.ReadLine(), out dataVencimento);
                        gerenciador.CriarTarefa(titulo, descricao, dataVencimento);
                        break;

                    case 2:
                        gerenciador.ListarTodasTarefas();
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome da tarefa a ser marcada como concluída:");
                        string nomeTarefa = Console.ReadLine();

                        Console.WriteLine("Tem certeza que deseja marcar esta tarefa como concluída? (sim/não)");
                        string resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            gerenciador.MarcarTarefaComoConcluida(nomeTarefa);
                        }
                        else if (resposta == "não")
                        {
                            Console.WriteLine("Operação cancelada.");
                        }
                        else
                        {
                            Console.WriteLine("Resposta inválida.");
                        }
                        break;
                    case 4:
                        gerenciador.ListarTarefasPendentes();
                        break;
                    case 5:
                        gerenciador.ListarTarefasConcluidas();
                        break;
                    case 6:
                        Console.WriteLine("Digite o nome da tarefa a ser excluída:");
                        string nomeTarefaExcluir = Console.ReadLine();

                        Console.WriteLine("Tem certeza que deseja excluir esta tarefa? (sim/não)");
                        string respostaExcluir = Console.ReadLine().ToLower();

                        if (respostaExcluir == "sim")
                        {
                            gerenciador.ExcluirTarefa(nomeTarefaExcluir);
                        }
                        else if (respostaExcluir == "não")
                        {
                            Console.WriteLine("Operação de exclusão cancelada.");
                        }
                        else
                        {
                            Console.WriteLine("Resposta inválida.");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Digite o nome da tarefa a ser pesquisada:");
                        string nomeTarefaPesquisar = Console.ReadLine();
                        gerenciador.PesquisarTarefa(nomeTarefaPesquisar);
                        break;
                    case 8:
                        gerenciador.MostrarEstatisticasBasicas();
                        break;
                    case 9:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Escolha novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha novamente.");
            }

        } while (opcao != 9);
    }
}
=======
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Todas as Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Pesquisar Tarefa por Palavra-Chave");
            Console.WriteLine("8. Exibir Estatísticas");
            Console.WriteLine("9. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarTarefa();
                    break;
                case 2:
                    ListarTodasAsTarefas();
                    break;
                case 3:
                    MarcarTarefaComoConcluida();
                    break;
                case 4:
                    ListarTarefasPendentes();
                    break;
                case 5:
                    ListarTarefasConcluidas();
                    break;
                case 6:
                    ExcluirTarefa();
                    break;
                case 7:
                    PesquisarPorPalavraChave();
                    break;
                case 8:
                    ExibirEstatisticas();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CriarTarefa()
    {
        Console.WriteLine("Digite o título da tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa:");
        string descricao = Console.ReadLine();

        Console.WriteLine("Digite a data de vencimento (DD/MM/AAAA):");
        DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Task novaTarefa = new Task(titulo, descricao, dataVencimento);
        tasks.Add(novaTarefa);
        Console.WriteLine("Tarefa criada com sucesso!");
    }

    static void ListarTodasAsTarefas()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Título: {task.Titulo} - Descrição: {task.Descricao} - Data de Vencimento: {task.DataVencimento.ToShortDateString()} - Concluída: {(task.Concluida ? "Sim" : "Não")}");
        }
    }

    // Implemente as outras funções conforme necessário (MarcarTarefaComoConcluida, ListarTarefasPendentes, ListarTarefasConcluidas, ExcluirTarefa, PesquisarPorPalavraChave, ExibirEstatisticas)
}

class Task
{
    public string Titulo { get; }
    public string Descricao { get; }
    public DateTime DataVencimento { get; }
    public bool Concluida { get; set; }

    public Task(string titulo, string descricao, DateTime dataVencimento)
    {
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        Concluida = false;
    }
}
>>>>>>> 7c5a480208e9bc7dbe39dddde3525b5b2dcde73d
