using System; 

class URI {

    static void Main(string[] args) { 
        Console.Clear();

        double a, b, c;

        string[] entrada = Console.ReadLine().Split();

         a = double.Parse(entrada[0]);
         b = double.Parse(entrada[1]);
         c = double.Parse(entrada[2]);

    
        Console.WriteLine($"Number = {a} Salario = {b*c}");

    }
}