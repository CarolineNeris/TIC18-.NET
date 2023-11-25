using System;
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
             Console.WriteLine("4. Listar tarefas concluídas");
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