using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

internal class ListaTarefas
{
    private string Nome;
    private List<Tarefa> tarefas;

    public ListaTarefas(string nome)
    {
        this.Nome = nome;
        this.tarefas = new List<Tarefa>();
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {

    }

    public bool RemoverTarefa(Tarefa tarefa)
    {
        return false;
    }

    public async Task BuscarTarefa(int id)
    {

    }

    public async Task ListarTarefas(List<Tarefa> tarefas)
    {

    }
}
