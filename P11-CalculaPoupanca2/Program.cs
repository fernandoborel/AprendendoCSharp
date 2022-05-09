using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - calcula poupança 2");

        double investimento = 1000;

        //rendimento de 0.5% ao mês.

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
        }

        

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}