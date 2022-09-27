using System; 

class URI {

    static void Main(string[] args) { 

        Console.Clear();

        int codigo1, codigo2, quantidade1, quantidade2;

        double preco1, preco2, valor1, valor2, total;

        string[] entrada1 = Console.ReadLine().Split();
        string[] entrada2 = Console.ReadLine().Split();

        codigo1 = int.Parse(entrada1[0]);
        codigo2 = int.Parse(entrada2[0]);

        quantidade1 = int.Parse(entrada1[1]);
        quantidade2 = int.Parse(entrada2[1]);

        preco1 = double.Parse(entrada1[2]);
        preco2 = double.Parse(entrada2[2]);

        valor1 = quantidade1*preco1;
        valor2 = quantidade2*preco2;

        Console.WriteLine(valor1);
        Console.WriteLine(valor2);

        total = valor1 + valor2;

        Console.WriteLine("TOTAL = "+total);

    }

}