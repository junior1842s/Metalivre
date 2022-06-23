using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] std)
        {
            Menu();
        }

    //MENU DE ACESSO
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual a Modalidade de uso?");
        Console.WriteLine("*************************");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - MULTIPLICAÇÃO");
        Console.WriteLine("4 - DIVISÃO");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("*************************");
        Console.Write("INFORME A OPÇÃO: ");
        
        short Modalidade = short.Parse(Console.ReadLine()); //Short é um  tipo de inteiro que não exige a largura completa do tipo Inteiro.

        switch (Modalidade)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 0: System.Environment.Exit(0); break;   //instrução de finalização da aplicação
            default: Menu(); break;
        }

    }

    //FASE DA SOMA
    public static void Soma()
    {   
        Console.Clear();
        Console.WriteLine("-----------SOMA-----------");
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());
        //Console.WriteLine("");

        float soma = valor1+valor2;                             //operação matemática
        Console.WriteLine($"É igual: {soma}");     //Valor interpolado

        Console.ReadKey();         //Aguarda interção do usuário par aprosseguir.
        Menu();
    } 

    //FASE DA SUBTRAÇÃO
    public static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("-----------SUBTRAÇÃO-----------");
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());
        //Console.WriteLine("");

        float subtracao = valor1 - valor2;                               //operacao matemática
        Console.WriteLine($"É igual: {subtracao}");   //valor interpolado

        Console.ReadKey();         //Aguarda interção do usuário par aprosseguir.
        Menu();
    }

    //FASE DE MULTIPLICAÇÃO
    public static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("-----------MULTIPLICAÇÃO-----------");
        Console.Write("Primeiro valor:  ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.Write("Primeiro valor:  ");
        float valor2 = float.Parse(Console.ReadLine());
        //Console.WriteLine("");

        float multiplicacao = (valor1 * valor2);
        Console.WriteLine($"É igual: {multiplicacao}");

        Console.ReadKey();         //Aguarda interção do usuário par aprosseguir.
        Menu();
    }

    //FASE DE DIVISÃO
    public static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("-----------DIVISÃO-----------");
        Console.Write("Primeiro valor:  ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Primeiro valor:  ");
        double valor2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("");

        double divisao = (valor1 / valor2);
        Console.WriteLine($"É igual: {divisao}");

        Console.ReadKey();         //Aguarda interção do usuário par aprosseguir.
        Menu();
    }
    


    }  
    
}