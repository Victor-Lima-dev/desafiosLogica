using System; 

class URI {

    static void Main(string[] args) { 
        Console.Clear();


        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

    
        Console.WriteLine($"Number = {a} Salario = {b*c}");

    }
}