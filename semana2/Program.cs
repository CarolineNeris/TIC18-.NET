using System;
using GerenciadorTarefas;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorTarefas.GerenciadorTarefas gerenciador = new GerenciadorTarefas.GerenciadorTarefas();

        int opcao = 0;
        do
        {
            Console.WriteLine("------ Menu ------");
            Console.WriteLine("1. Criar Tarefa");
            Console.Write("Escolha uma opção: ");
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