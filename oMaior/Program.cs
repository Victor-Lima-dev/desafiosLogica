using System;

namespace Beecrowd
{

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();

        string[] entrada = Console.ReadLine().Split();

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        int maiorAB = (a+b+Math.Abs(a-b))/2;

        int maior = 0;
         maior = (maiorAB + c + Math.Abs(c-maiorAB))/2;

        Console.WriteLine(maior+" "+"eh o maior");

        Console.ReadKey();

        
    }

}


}
