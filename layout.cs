using System;

namespace Layout
{
    public static class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
    }

    public static void ImprimirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("     GERENCIADOR DE TAREFAS  ");
        Console.WriteLine("=============================");
        Console.WriteLine();
    }
}