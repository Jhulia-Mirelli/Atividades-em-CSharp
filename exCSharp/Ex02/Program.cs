namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine(n + " é par");
        }
        else
        {
            Console.WriteLine(n + " é ímpar");
        }
    }
}
