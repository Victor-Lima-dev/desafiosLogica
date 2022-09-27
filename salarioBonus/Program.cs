using System;

class URI
{

    static void Main(string[] args)
    {
        Console.Clear();
        string nome;
        int salario, vendas;

        double c;

        nome = Console.ReadLine();

        salario = int.Parse(Console.ReadLine());
        vendas = int.Parse(Console.ReadLine());

        c = (0.15 * vendas) + salario;
        

        Console.WriteLine($"TOTAL = {c}");



    }

}