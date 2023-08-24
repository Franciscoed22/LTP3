using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Nome:");
        var nome = Console.ReadLine();
        Console.WriteLine ("Sobrenome:");
        var sobrenome = Console.ReadLine();
        Console.WriteLine ("Seu nome completo:");
        Console.WriteLine (nome + " " + sobrenome);
    }
}