using System;
using System.Globalization;

namespace Area
{
    public class TamanhoArea
    {
        public static void Main(String[] X)
        {
            string[] Area = Console.ReadLine().Split(' ');
            int A = double.Parse(Area[0], CultureInfo.InvariantCulture);
            int B = double.Parse(Area[2], CultureInfo.InvariantCulture);
            int C = double.Parse(Area[3], CultureInfo.InvariantCulture);
            double pi = 3.14159;
            
            //leia 3 valores A B e C com ponto flutuante de dupla precisão
            //double A, B, C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Base
            //double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Lado
            //double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Altura
            
            //Mostre a área do Triângulo retângulo A por base e C por Altura
            double AreaTri = (A*C)/2;
            //área do circulo C (pi = 3.14159)  -- Formula A = pi*R²
            double AreaC = pi * C * C;
            //área do trapézio  A e B por base e C por altura
            double AreaTra = (A + B * C)/2;
            //área do quadrado que tem Lado B
            double AreaQ = (B*B)*(A*A);
            //área do retângulo que tem lados A e B
            double AreaR = (B*B)*(A*A);
            //*******************************************************************

            Console.WriteLine("TRIANGULO: "+AreaTri.ToString("F3", CultureInfo.InvariantCulture)); //Área do Triângulo
            Console.WriteLine("CIRCULO: "+AreaC.ToString("F3", CultureInfo.InvariantCulture)); //Área do Circulo                      
            Console.WriteLine("TRAPEZIO: "+AreaTra.ToString("F3", CultureInfo.InvariantCulture)); //Área do Trapézio
            Console.WriteLine("QUADRADO: "+AreaQ.ToString("F3", CultureInfo.InvariantCulture)); //Área do Quadrado
            Console.WriteLine("RETANGULO: "+AreaR.ToString("F3", CultureInfo.InvariantCulture)); //Área do Retângulo                         
        }
    }

}