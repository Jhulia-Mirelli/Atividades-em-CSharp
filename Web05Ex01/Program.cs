namespace Web05Ex01;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int n = 0;
        while (true)
        {
            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                soma += n;
            }
            else
            {
                break;
            }

        }
        Console.WriteLine("Valor Digitado: " + n + "Soma dos positivos: " + soma);
    }
}
