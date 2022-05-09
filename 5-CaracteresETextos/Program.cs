using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e textos");
        
        char letra = 'a';
        Console.WriteLine(letra);

        string primeiraFrase = "Aoooh da roça!";
        Console.WriteLine(primeiraFrase);

        string cursosDisponiveis = @"Cursos disponíveis: 
- Java
- C#
- JavaScript";
        Console.WriteLine(cursosDisponiveis);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}

