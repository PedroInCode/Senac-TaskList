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
    //Propriedade Privada -> _prop

    private int _id;
    private string _titulo;
    private string _descricao;
    private DateTime _dataCriacao;
    private DateTime? _prazo;
    private StatusTarefa _status;
    private Prioridade _prioridade;
    private List<Etiqueta> _etiquetas;

    //Propriedades de acesso
    //Propriedade Pública -> Primeira letra Maiuscula

    public int Id => _id; // Retorna o valor da variavel id principal
    public string Titulo => _titulo;
    public string Descricao => _descricao;
    public DateTime DataCriacao => _dataCriacao;
    public DateTime? Prazo => _prazo;
    public StatusTarefa Status => _status;
    public Prioridade Prioridade => _prioridade;
    public IReadOnlyList<Etiqueta> Etiquetas => _etiquetas.AsReadOnly(); //Impedir que adicionem etiquetas fora dos métodos corretos

    // Propriedades no construtor -> (minusculo)
    public Tarefa(int id, string titulo, string descricao, Prioridade prioridade, DateTime? prazo = null)
    {
        this._id = id;
        this._titulo = titulo;
        this._descricao = descricao;
        this._dataCriacao = DateTime.Now;
        this._prazo = prazo;
        this._status = StatusTarefa.Pendente;
        this._prioridade = prioridade;
        this._etiquetas = new List<Etiqueta>();
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
