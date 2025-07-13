namespace Ex08;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        Console.WriteLine("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                cont++;
            }
        }
        Console.WriteLine(cont);
        if (cont == 2)
        {
            Console.WriteLine(n + " é um número primo.");
        }
        else
        {
            Console.WriteLine(n + " não é um número primo.");
        }

    }
}
