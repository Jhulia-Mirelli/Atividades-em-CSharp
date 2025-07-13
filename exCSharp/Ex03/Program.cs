namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        Console.Write("Digite o 1° Valor: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2° Valor: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha uma operação (1:+ 2:- 3:* 4:/): ");
        int res = int.Parse(Console.ReadLine());
        if (res == 1)
        {
            soma = n1 + n2;
            Console.WriteLine(n1 + "+" + n2 + " é igual: " + soma);
        }
        if (res == 2)
        {
            soma = n1 - n2;
            Console.WriteLine(n1 + "-" + n2 + " é igual: " + soma);
        }
        if (res == 3)
        {
            soma = n1 * n2;
            Console.WriteLine(n1 + "x" + n2 + " é igual: " + soma);
        }
        else
        {
            soma = n1 / n2;
            Console.WriteLine(n1 + "/" + n2 + " é igual: " + soma);
        }
    }
}
