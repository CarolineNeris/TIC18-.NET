using System;
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
