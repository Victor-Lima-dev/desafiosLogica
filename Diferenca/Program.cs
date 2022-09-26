using System; 

class URI {

    static void Main(string[] args) { 

        Console.Clear();

        string[] entrada = Console.ReadLine().Split();

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);

        int c = int.Parse(entrada[2]);
        int d = int.Parse(entrada[3]);

        int diferenca = Math.Abs((a * b) - (c*d));

        Console.WriteLine($"{diferenca}");



    }

}