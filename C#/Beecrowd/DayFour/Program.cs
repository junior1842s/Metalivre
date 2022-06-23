using System;

namespace Program
{
public class Media   
{
    public static void Main()
    {   //valor da primeira nota
        double A = double.Parse(Console.ReadLine());
        //Peso da nota a
        double PA = 3.5;

        //Valora da segunda nota
        double B = double.Parse(Console.ReadLine());
        //Peso da nota B 
        double PB = 7.5;

        //double C = double.Parse(Console.ReadLine());
            //******************************
            //double Media = (A + B + C)/3;
            //double MP = ((float)Media);
            //******************************

        double MediaP = (A * PA + B * PB) / (PA + PB);
        double MP = ((float)MediaP);

       Console.WriteLine(MP.ToString("F5"));

        //Console.WriteLine($"MEDIA = {MediaP}");
        //Console.WriteLine("Media = " + (MediaP.ToString("0.00000")));
        //Console.WriteLine(MediaP.ToString("F5"));

    }
}
}
