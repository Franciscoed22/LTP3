// 01
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("digite um numero inteiro:");
        var numInteiro = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("o numero inteiro: " + numInteiro);

    }
}

// 02
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

// 03
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

// 04
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("digite um numero para calcular:");
        var numACalcular = Convert.ToInt32(Console.ReadLine());
        var zero = 0*numACalcular;
        var one = 1*numACalcular;
        var two = 2*numACalcular;
        var tres = 3*numACalcular;
        var quatro = 4*numACalcular;
        var five = 5*numACalcular;
        var six = 6*numACalcular;
        var seven = 7*numACalcular;
        var oito = 8*numACalcular;
        var nove = 9*numACalcular;
        var dez = 10*numACalcular;

        Console.WriteLine ("o numero x0 = " +  zero);
        Console.WriteLine ("o numero x1 = " +  one);
        Console.WriteLine ("o numero x2 = " +  two);
        Console.WriteLine ("o numero x3 = " +  tres);
        Console.WriteLine ("o numero x4 = " +  quatro);
        Console.WriteLine ("o numero x5 = " +  five);
        Console.WriteLine ("o numero x6 = " +  six);
        Console.WriteLine ("o numero x7 = " +  seven);
        Console.WriteLine ("o numero x8 = " +  oito);
        Console.WriteLine ("o numero x9 = " +  nove);
        Console.WriteLine ("o numero x10 = " +  dez);

    }
}

// 05
using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite um numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine ("O numero " + numero +" e par");
        }
        else
        {
            Console.WriteLine ("O numero " + numero +" e impar");
        }
    }
}

// 06
using System;
using System.Text;

public class SomaOuTriplo
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Digite o primeiro valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        double soma = valor1 + valor2;

        if (valor1 == valor2)
        {
            double triploDaSoma = 3 * soma;
            Console.WriteLine("Os valores são iguais. O triplo da soma é: " + triploDaSoma);
        }
        else
        {
            Console.WriteLine("A soma dos valores é: " + soma);
        }
    }
}
