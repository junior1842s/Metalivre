using System;
using System.Globalization;

namespace Area
{   
    public class MyClass
    {
        public static void Main(String[] X)
        {
            //Volume de um esfera 
            //Radio R
            //Fomula (4/3)*pi*R³ - pi = 3.14159
            double pi = 3.14159;
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Formula = (4.0/3)*(pi*R*R*R);

            Console.WriteLine("VOLUME = "+Formula.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
    
}