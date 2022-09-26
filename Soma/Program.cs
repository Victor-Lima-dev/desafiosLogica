using System; 

class URI {

    static void Main(string[] args) { 
Soma();
    }

    static void Soma()
    {
        Console.Clear();
        string[] entrada = Console.ReadLine().Split();

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);

        int soma = a + b;

        Console.WriteLine($"SOMA = {soma}");
    }

}