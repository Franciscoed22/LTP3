using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Insira o seu nome completo");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual a sua idade");
        string idadeConsol = Console.ReadLine();

        string nomeMaiu = nome.ToUpper();
        string nomeMin = nome.ToLower();

        Console.WriteLine(nomeMaiu);
        Console.WriteLine(nomeMin);

        int numCaracter = nome.Replace(" ", "").Length;
        int idade = Convert.ToInt32(idadeConsol);
        Console.WriteLine("Número de caracteres no seu nome completo: " + numCaracter);

        int yearNascimento = 2023 - idade;
        Console.WriteLine("Seu ano de nascimento é: " + yearNascimento);

        int idadeCentenario = 100 - idade;
        Console.WriteLine("Você vai fazer 100 anos em: " + (2023 + idadeCentenario));
    }
}