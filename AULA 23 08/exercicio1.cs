using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var anoNascimento = Convert.ToInt32(Console.ReadLine());
        var anoAtual = Convert.ToInt32(DateTime.Now.Year.ToString());
        var idade = (anoAtual - anoNascimento);
        Console.WriteLine ("Sua idade: " + idade);
    }
}