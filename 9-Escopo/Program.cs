using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");
        
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado.";
        } 
        else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado || grupo)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }
        

        int salario = 2700;


        if(salario >= 1556 && salario <= 2594)
        {
            Console.WriteLine("Alíquota de 9%");
            int salarioLiquido = (int)(salario * 0.09);
            Console.WriteLine("Desconto do INSS " + salarioLiquido);
        }
        else
        {
            Console.WriteLine("Alíquota de 11%");
            int salarioLiquido = (int)(salario * 0.11);
            Console.WriteLine("Desconto do INSS " + salarioLiquido);
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}

