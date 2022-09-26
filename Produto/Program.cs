using System; 

class URI {

    static void Main(string[] args) { 

        Console.Clear();

        string[] entrada = Console.ReadLine().Split();
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);

        int produto = a*b;

        Console.WriteLine($"Produto = {produto}");

       
    }

}