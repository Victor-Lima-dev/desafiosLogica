using System;

class URI
{
    static void Main(string[] args)
    {
        AreaCirculo();
    }

    static void AreaCirculo()
    {
        Console.Clear();
        string[] entrada = Console.ReadLine().Split();

        double r = double.Parse(entrada[0]);

        r = Math.Pow(r,2);


        double area = 3.14159 * r;

        //area = Math.Round(area,4);

         Console.WriteLine("A={0:F4}", area);



    }
}