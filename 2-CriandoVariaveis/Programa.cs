using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando váriaveis");

        int idade;
        idade = 27;

        Console.WriteLine("Minha idade é " + idade);

        idade = (9 * 8) / 2;

        Console.WriteLine("Nova idade: " +idade);

        idade = idade / 2;

        Console.WriteLine("A nova idade é: " +idade);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
