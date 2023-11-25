using System;
using System.Collections.Generic;
namespace app
{

    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Concluida { get; set; }
    }
    public class GerenciadorTarefas
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public void CriarTarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa
            {
                Titulo = titulo,
                Descricao = descricao,
                DataVencimento = dataVencimento,
                Concluida = false
            };
            tarefas.Add(novaTarefa);
        }
        public void ListarTodasTarefas()
        {
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Título: {tarefa.Titulo}, Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento}, Concluída: {tarefa.Concluida}");
            }
        }
        public void MarcarTarefaComoConcluida(string nomeTarefa)
        {
            Tarefa tarefaEncontrada = tarefas.Find(t => t.Titulo.Equals(nomeTarefa, StringComparison.OrdinalIgnoreCase));

            if (tarefaEncontrada != null)
            {
                tarefaEncontrada.Concluida = true;
                Console.WriteLine($"Tarefa '{nomeTarefa}' marcada como concluída.");
            }
            else
            {
                Console.WriteLine($"Tarefa '{nomeTarefa}' não encontrada.");
            }
        }
        public void ListarTarefasPendentes()
        {
            foreach (Tarefa tarefa in tarefas)
            {
                if (!tarefa.Concluida)
                {
                    Console.WriteLine($"Título: {tarefa.Titulo}, Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento}");
                }
            }
        }
  public void ListarTarefasConcluidas()
    {
        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.Concluida)
            {
                Console.WriteLine($"Título: {tarefa.Titulo}, Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento}");
            }
        }
    }
    }

}