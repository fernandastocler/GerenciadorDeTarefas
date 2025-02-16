GerenciadorDeTarefas.cs
using System;
using System Collections.Generic;
using Layout;
using Tarefas;

namespace GerenciadorTarefa
{
  public static class GerenciadorTarefa
  { 
    private static List<Tarefa> listaDeTarefas = new List<Tarefa>();
    private static int contadorId = 1;
  }
   
    Formatacao.Cor("Digite a descrição de tarefa:", ConsoleColor.white);
    string descricao = Console.ReadLine();
    listaDeTarefas.Add(new Tarefa(contadorId, descricao));
    contadorId++;
    Formatacao.Cor("Tarefa Adicionada com sucesso!", ConsoleColor.Green);
      {

            public static void AdicionarTarefa()
            }
             ListarTarefas();
             Formatacao.Cor("Digite o ID da tarefa a concluir:", Console.Write);
             if (int.TryParse(Console.ReadLine(), out int id))
             {
              Tarefa tarefa = listaDeTarefas.Find(tarefa => tarefa.Id == id);
              if (tarefa != null)
             }
              tarefa.Concluida = true;
              Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
              {
                else
                {
                  Formatacao.Cor("ID inválido!", ConsoleColo);
                }
              }
            {
              public static void RemoverTarefas()
            }
            ListarTarefas();
            Formatacao.Cor("Digite o ID da tarefa a remover:", ConsoleColo.Write);
            if (int.TryParse(Console.ReadLine(), out int id))
            {
              ListarTarefas tarefa = listarDeTarefas.Find(t => t.Id == id);
              if (tarefa != null)
            {
            listaDeTarefas.Removedor(RemoverTarefas); 
            Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
            }
            else
            }
             Formatacao.Cor("ID inválido!", ConsoleColor.Red);
        }
      }
}
}
}   