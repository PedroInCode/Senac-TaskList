using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

internal class ListaTarefas
{
    private string _nome;
    private List<Tarefa> _tarefas;

    public string Nome => _nome;
    public IReadOnlyList<Tarefa> Tarefas => _tarefas.AsReadOnly();

    public ListaTarefas(string nome)
    {
        this._nome = nome;
        this._tarefas = new List<Tarefa>();
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        if (!_tarefas.Contains(tarefa))
        {
            _tarefas.Add(tarefa);
        }

    }

    public bool RemoverTarefa(int id)
    {
        var tarefa = BuscarTarefa(id);

        if(tarefa != null)
            return this._tarefas.Remove(tarefa);

        Console.WriteLine("Tarefa não existe!");
        return false;
    }

    public Tarefa? BuscarTarefa(int id)
    {
        return this._tarefas.FirstOrDefault(ta => ta.Id == id);
    }

    public List<Tarefa> ListarTarefas()
    {
        return this._tarefas.ToList();
    }

    public List<Tarefa> ListarTarefasPorStatus(StatusTarefa status)
    {
        List<Tarefa> tarefasFiltradas = this._tarefas.Where(tarefa => tarefa.Status == status).ToList();
        return tarefasFiltradas;
    }

    public List<Tarefa> ListarTarefasPorPrioridade(Prioridade prioridade)
    {
        List<Tarefa> tarefasFiltradas = this._tarefas.Where(tarefa => tarefa.Prioridade == prioridade).ToList();
        return tarefasFiltradas;
    } 
}
