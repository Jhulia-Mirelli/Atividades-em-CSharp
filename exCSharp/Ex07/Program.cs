namespace Ex07;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        Console.Write("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
            soma += i;
        }
        Console.WriteLine(soma);
    }
}
