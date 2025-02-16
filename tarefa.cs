tarefa.cs
using System;

namespace tarefa
{
    public interface Id { get; set; }
     public string Descricao { get; set; }
     public bool Concluida { get; set; }

     public Tarefas(int id, string descricao)
{
     id = Id;
     Descricao = descricao;
     Concluida = false;
}
public void ExibirTarefas()
{
    string status = Concluida ? "[X]" : "[ ]";
    Console.WriteLine(${status} ID: {id} - {Descricao}");
   }
 }
}