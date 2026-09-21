using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backListaTarefas;

public class Etiqueta
{
    private string Nome;
    private string Cor;

    public Etiqueta(string nome, string cor)
    {
        this.Nome = nome;
        this.Cor = cor;
    }

    public void Renomear(string novoNome)
    {
        this.Nome = novoNome;
    }
}
