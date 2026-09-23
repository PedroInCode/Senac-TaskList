using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

public class Etiqueta
{
    private string _nome;
    private string _cor;

    public string Nome => _nome;
    public string Cor => _cor;

    public Etiqueta(string nome, string cor)
    {
        this._nome = nome;
        this._cor = cor;
    }

    public void Renomear(string novoNome)
    {
        this._nome = novoNome;
    }
}
