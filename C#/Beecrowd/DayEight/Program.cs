using System;
using System.Globalization;
namespace SalarioFuncionario
{
    class Comissao
    {
        static void Main()
        {
            //Nome do vendedor
            //Salario fixo
            //Total de vendas efetuadas no mês
            //Comissao 15% sobre as vendas
            //Total a receber no final do mês (salario) com duas casas decimais

            string Nome = Console.ReadLine();   
            double SFixo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Comissao = 0.15*Vendas;
            double Salario = SFixo + Comissao;
            
            Console.WriteLine($"TOTAL = R$ {Salario.ToString("F2")}");
        }

    }
}