using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

internal class ListaTarefas
{
    private string _nome;
    private List<Tarefa> tarefas;

    public ListaTarefas(string nome)
    {
        this._nome = nome;
        this.tarefas = new List<Tarefa>();
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        if (!tarefas.Contains(tarefa))
        {
            tarefas.Add(tarefa);
        }

    }

    public bool RemoverTarefa(int id)
    {
        var tarefa = BuscarTarefa(id);

        if(tarefa != null)
            return this.tarefas.Remove(tarefa);

        return false;
    }

    public Tarefa? BuscarTarefa(int id)
    {
        foreach(Tarefa tarefa in this.tarefas)
        {
            if(tarefa.Id == id)
                return tarefa;
        }

        return null;
    }

    public List<Tarefa> ListarTarefas()
    {
        return this.tarefas.ToList();
    }

    public List<Tarefa>? ListarTarefasPorStatus(StatusTarefa status)
    {
        List<Tarefa> tarefasFiltradas = new();

        foreach (Tarefa tarefa in this.tarefas)
        {
            if (tarefa.Status == status)
            {
                tarefasFiltradas.Add(tarefa);
            }
        }

        if (tarefasFiltradas.Count == 0)
        {
            Console.WriteLine($"A lista não contém tarefas com status {status}");
            return null;
        }

        return tarefasFiltradas;
    }

    public List<Tarefa>? ListarTarefasPorPrioridade(Prioridade prioridade)
    {
        List<Tarefa> tarefasFiltradas = new();

        foreach (Tarefa tarefa in this.tarefas)
        {
            if (tarefa.Prioridade == prioridade)
            {
                tarefasFiltradas.Add(tarefa);
            }
        }

        if (tarefasFiltradas.Count == 0)
        {
            Console.WriteLine($"A lista não contém tarefas com prioridade {prioridade}");
            return null;
        }

        return tarefasFiltradas;
    }

   
}
