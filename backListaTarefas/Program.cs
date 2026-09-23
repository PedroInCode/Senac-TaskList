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
        ListaTarefas listaTarefa = new("Tarefas Back-end");

        //Adicionando tarefas na lista
        listaTarefa.AdicionarTarefa(tarefaSemPrazo);
        listaTarefa.AdicionarTarefa(tarefaAtrasada);

        //Exibindo as tarefas dentro da lista
        Console.WriteLine("-------- PAINEL TAREFAS ---------\n");
        foreach(Tarefa tarefa in listaTarefa.ListarTarefas())
        {
            Console.WriteLine($"[{tarefa.Id}] Titulo: {tarefa.Titulo}\n" +
                $"    Status: {tarefa.Status}\n" +
                $"    Prioridade: {tarefa.Prioridade}");

            foreach(Etiqueta tag in tarefa.Etiquetas)
            {
                Console.Write($"{tag.Nome} {tag.Cor}");
            }
        }


    }
}