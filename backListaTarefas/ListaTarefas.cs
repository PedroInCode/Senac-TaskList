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
       
    }

    public void ListarTarefaPorStatus(StatusTarefa status)
    {
        
    }
}
