using ContaBancaria;
using System;


public class Program
{
    public static void Main()
    {
        // Exemplo 1
        ContaBancariaC conta1 = new ContaBancariaC(5447, "Milton Gonçalves");
        conta1.MostrarDadosConta();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta1 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (resposta1 == 's' || resposta1 == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial1 = Convert.ToDouble(Console.ReadLine());
            conta1.Depositar(depositoInicial1);
        }

        Console.Write("Entre um valor para depósito: ");
        double deposito1 = Convert.ToDouble(Console.ReadLine());
        conta1.Depositar(deposito1);

        Console.Write("Entre um valor para saque: ");
        double saque1 = Convert.ToDouble(Console.ReadLine());
        conta1.Sacar(saque1);

        // Exemplo 2
        ContaBancariaC conta2 = new ContaBancariaC(5139, "Elza Soares");
        conta2.MostrarDadosConta();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta2 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (resposta2 == 's' || resposta2 == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial2 = Convert.ToDouble(Console.ReadLine());
            conta2.Depositar(depositoInicial2);
        }

        Console.Write("Entre um valor para depósito: ");
        double deposito2 = Convert.ToDouble(Console.ReadLine());
        conta2.Depositar(deposito2);

        Console.Write("Entre um valor para saque: ");
        double saque2 = Convert.ToDouble(Console.ReadLine());
        conta2.Sacar(saque2);
    }
}