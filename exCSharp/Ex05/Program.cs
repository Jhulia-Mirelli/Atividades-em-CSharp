namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("TABUADA DO " + n);
        for (int i = 1; i <= 10; i++)
        {
            int div = n * i;
            Console.WriteLine(n + "x" + i + "=" + div);
        }
    }
}
