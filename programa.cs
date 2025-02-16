using System;
using GerenciadorTarefas;
using layout;

class Program
{
    static void Main()
{
    while (true)
{
    Formatacao.ImprimirCabecalho();
    Console.WriteLine("1 - Adicionar Tarefas");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Concluir Tarefas");
    Console.WriteLine("4 - Removedor Tarefas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
}
    case "1":
     GerenciadorTarefas.AdicionandoTarefas();
        break;
    case "2":
     GerenciadorTarefas.ListarTarefas();
        break;
    case "3":
     GerenciadorTarefas.ConcluirTarefas();
       break;
    case "4":
     GerenciadorTarefas.RemoverTarefas();
       break;
    case "0":
     Formatacao.Cor("Saindo...", ConsoleColor.Red);
       return;
    default:
     Formatacao.Cor("Opção inválida!", ConsoleColor.Red);
      break;
}

 Console.WriteLine("/nPressione qualquer tecla para continuar...");
 Console.ReadKey();
 }
}
