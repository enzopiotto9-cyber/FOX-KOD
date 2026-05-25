//faça uma calculadora complexa usando tudo oque você sabe;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Calculadora Complexa!");
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potenciação");
        Console.WriteLine("6 - Radiciação");
        Console.WriteLine("7 - Logaritmo");

        int escolha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (escolha)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Erro: Divisão por zero!");
                break;
            case 5:
                resultado = Math.Pow(num1, num2);
                break;
            case 6:
                if (num1 >= 0)
                    resultado = Math.Sqrt(num1);
                else
                    Console.WriteLine("Erro: Radiciação de número negativo!");
                break;
            case 7:
                if (num1 > 0 && num2 > 0)
                    resultado = Math.Log(num1, num2);
                else
                    Console.WriteLine("Erro: Logaritmo de número não positivo!");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        if (escolha >= 1 && escolha <= 7)
            Console.WriteLine($"O resultado é: {resultado}");
    }
}