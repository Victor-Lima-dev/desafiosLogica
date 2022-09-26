using System; 

class URI {

    static void Main(string[] args) { 

        Console.Clear();
        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);

        double media = (a + b)*0.5;

        Console.WriteLine("MEDIA = {0:F5}",media);

    }

}