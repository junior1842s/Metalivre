using System;
 namespace ParametrosOpicionais
 {
    public class Opicionais
    {   
        static decimal Faturamento(decimal qtde, decimal preco, decimal bonus = 0.05*100/bonus) => qtde * preco + bonus;
        static void Main(strin[] args)
        {
            
        }
    }
 }