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

        public GerenciadorTarefas()
{
    // Tarefaz preé inseridas para facilitar realização de testes
    tarefas.Add(new Tarefa
    {
        Titulo = "Estudar C#",
        Descricao = "Praticar exemplos de código e fazer exercícios.",
        DataVencimento = DateTime.Parse("12/12/2023"), 
        Concluida = false
    });

    tarefas.Add(new Tarefa
    {
        Titulo = "Fazer compras",
        Descricao = "Comprar itens do mercado.",
        DataVencimento = DateTime.Parse("11/11/2023"), 
        Concluida = true
    });
    tarefas.Add(new Tarefa
    {
        Titulo = "Chorar",
        Descricao = "Chorar no colo da minha mãe",
        DataVencimento = DateTime.Parse("04/10/2023"), 
        Concluida = true
    });
    tarefas.Add(new Tarefa
    {
        Titulo = "Pedir ponto extra",
        Descricao = "pedir ponto extra ao professor Helder",
        DataVencimento = DateTime.Parse("28/11/2023"), 
        Concluida = false
    });
    
}
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
        public void ExcluirTarefa(string nomeTarefa)
        {
            Tarefa tarefaEncontrada = tarefas.Find(t => t.Titulo.Equals(nomeTarefa, StringComparison.OrdinalIgnoreCase));

            if (tarefaEncontrada != null)
            {
                tarefas.Remove(tarefaEncontrada);
                Console.WriteLine($"Tarefa '{nomeTarefa}' excluída com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa '{nomeTarefa}' não encontrada para exclusão.");
            }
        }
        public void PesquisarTarefa(string nomeTarefa)
        {
            Tarefa tarefaEncontrada = tarefas.Find(t => t.Titulo.Equals(nomeTarefa, StringComparison.OrdinalIgnoreCase));

            if (tarefaEncontrada != null)
            {
                Console.WriteLine($"Tarefa encontrada - Título: {tarefaEncontrada.Titulo}, Descrição: {tarefaEncontrada.Descricao}, Data de Vencimento: {tarefaEncontrada.DataVencimento}, Concluída: {tarefaEncontrada.Concluida}");
            }
            else
            {
                Console.WriteLine($"Tarefa '{nomeTarefa}' não encontrada.");
            }
        }
        public void MostrarEstatisticasBasicas()
        {
            int tarefasConcluidas = 0;
            int tarefasPendentes = 0;
            DateTime tarefaMaisAntiga = DateTime.MaxValue;
            DateTime tarefaMaisRecente = DateTime.MinValue;

            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.Concluida)
                {
                    tarefasConcluidas++;
                }
                else
                {
                    tarefasPendentes++;
                }

                if (tarefa.DataVencimento < tarefaMaisAntiga)
                {
                    tarefaMaisAntiga = tarefa.DataVencimento;
                }

                if (tarefa.DataVencimento > tarefaMaisRecente)
                {
                    tarefaMaisRecente = tarefa.DataVencimento;
                }
            }

            Console.WriteLine($"Número de tarefas concluídas: {tarefasConcluidas}");
            Console.WriteLine($"Número de tarefas pendentes: {tarefasPendentes}");
            Console.WriteLine($"Data da tarefa mais antiga: {tarefaMaisAntiga}");
            Console.WriteLine($"Data da tarefa mais recente: {tarefaMaisRecente}");
        }

        
    }

}

