using System;
using System.Globalization;

namespace EstoqueDaFabrica
{
    public class Pecas
    {
        static void Main()
        {
            string[] Compra = Console.ReadLine().Split(' ');
            int CodPeca = int.Parse(Compra[0]);
            int NumPeca = int.Parse(Compra[1]);
            double ValorPeca = double.Parse(Compra[2], CultureInfo.InvariantCulture);

            string[] Compra1 = Console.ReadLine().Split(' ');
            int CodPeca1 = int.Parse(Compra1[0]);
            int NumPeca1 = int.Parse(Compra1[1]);
            double ValorPeca1 = double.Parse(Compra1[2], CultureInfo.InvariantCulture);

            double Total = (NumPeca*ValorPeca) + (NumPeca1*ValorPeca1);

            Console.WriteLine("VALOR A PAGAR: R$ {0}",Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}