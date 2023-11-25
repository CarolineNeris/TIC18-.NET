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
    }

}