namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o 1 valor: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2 valor: ");
        int n2 = int.Parse(Console.ReadLine());
        if (n1 > n2)
        {
            Console.WriteLine(n1 + " é maior que " + n2);
        }
        if (n2 > n1)
        {
            Console.WriteLine(n2 + " é maior que " + n1);
        }
        if (n1 == n2)
        {
            Console.WriteLine(n1 + " é igual " + n2);
        }
    }
}
