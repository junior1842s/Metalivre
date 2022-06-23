using System; 

class URI {

    static void Main(string[] a) { 
        int V1 = int.Parse(Console.ReadLine());
        int V2 = int.Parse(Console.ReadLine());
        
        int PROD = V1 * V2;
        
        Console.WriteLine($"PROD = {PROD}");
    }

}