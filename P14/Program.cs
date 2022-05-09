using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando for");

        for(int i = 0; i < 100; i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

