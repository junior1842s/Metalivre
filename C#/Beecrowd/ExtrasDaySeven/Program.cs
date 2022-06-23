using System;
using System.Globalization;

namespace Salariodd
{
    class HorasTrabalhadas
    {
        static void Main()
        {
            //Receber um Numero = N
            //Numero de horas trabalhadas = HT
            //valor por hora = H
//            NumberFormatInfo nfi = new CultureInfo("en-US").NumberFormat;
            int Funcionario = Convert.ToInt32(Console.ReadLine());              //Numero do funcionário
            int Hours = Convert.ToInt32(Console.ReadLine());          //Horas trabalhadas
            double valorHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); //valor por horas
            
            double Salary = (valorHora*Hours);
            
            Console.WriteLine($"NUMBER = {Funcionario}\nSALARY = U$ {Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }

}