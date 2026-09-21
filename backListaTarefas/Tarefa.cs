using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

public enum StatusTarefa
{
    Pendente,
    EmAndamento,
    Concluido
}

public enum Prioridade
{
    Baixa,
    Media,
    Alta,
    Urgente
}

internal class Tarefa
{
    //Propriedades privadas
    private int id;
    private string titulo;
    private string descricao;
    private DateTime dataCadastro;
    private DateTime? prazo;
    private StatusTarefa status;
    private Prioridade prioridade;
    private List<Etiqueta> etiquetas;

    //Propriedades de acesso
    public int Id => id; // Retorna o valor da variavel id principal
    public string Titulo => titulo;
    public string Descricao => descricao;
    public DateTime DataCadastro => dataCadastro;
    public DateTime? Prazo => prazo;
    public StatusTarefa Status => status;
    public Prioridade Prioridade => prioridade;
    //Impedir que adicionem etiquetas fora dos métodos corretos
    public IReadOnlyList<Etiqueta> Etiquetas => etiquetas.AsReadOnly();

    public Tarefa()
    {
        
    }

    public void Concluir()
    {

    }

    public void Reabrir()
    {

    }

    public void AlterarPrazo(DateTime prazo)
    {

    }

    public void AdicionarEtiqueta(Etiqueta etiqueta)
    {

    }

    public void RemoverEtiqueta(Etiqueta etiqueta)
    {

    }

    public bool EstaAtrasada()
    {
        return true;
    }
}
