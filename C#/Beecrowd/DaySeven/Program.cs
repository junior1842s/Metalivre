using System;


namespace MyNamespace
{
    class MinhaClasse
    {
        static void Main(string[] a)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());  

            int Dif =  (A*B) - (C*D);

            Console.WriteLine("DIFERENCA = "+Dif);
        }
    }
    
}