using System;
using System.Globalization;
namespace Program{
    class MediaPonderada{
        public static void Main(){
        //Notas dos três semestres
        double A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  //Peso = 2
        double B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  //Peso = 3
        double C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  //Peso = 5
        //Função da Média
        double Media = (A*2 + B*3 + C*5) / 10;
        //Exibição
        Console.WriteLine($"MEDIA = {Media.ToString("F1", CultureInfo.InvariantCulture)}");
        //Fim do programa            
        }
    }
    
}