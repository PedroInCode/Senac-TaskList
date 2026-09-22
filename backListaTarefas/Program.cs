using backListaTarefas;

internal class Program
{
    
    static void Main(string[] args)
    {
        //Etiqueta Back-End
        Etiqueta tagBackend = new("Backend", "Verde");

        Tarefa tarefaSemPrazo = new Tarefa(
            1, 
            "Desenvolver Controller",
            "Desenvolver o controller de produto na api adega",
            Prioridade.Alta
            );

        tarefaSemPrazo.AlterarPrazo(new DateTime(2026, 10, 17));

        Tarefa tarefaAtrasada = new Tarefa(
            2,
            "Implementar DTOs na API",
            "Aprimorar segurança ao acesso dos dados",
            Prioridade.Alta,
            DateTime.Now.AddDays(-2)
            );
        //Adicionando Etiquetas nas tarefas
        tarefaSemPrazo.AdicionarEtiqueta(tagBackend);
        tarefaAtrasada.AdicionarEtiqueta(tagBackend);

        //Criando Lista de Tarefa
        ListaTarefas lista1 = new("Tarefas Back-end");


        lista1.AdicionarTarefa(tarefaSemPrazo);
        //lista1.AdicionarTarefa(tarefaAtrasada);
        //lista1.ListarTarefaPorStatus(StatusTarefa.Concluido);

        lista1.BuscarTarefa(1);


    }
}