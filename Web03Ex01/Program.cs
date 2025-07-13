namespace Web03Ex01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Valor de Fábrica: R$");
        double valor_fabri = double.Parse(Console.ReadLine());
        double valor_total = ((valor_fabri * (0.28 + 0.45)) + valor_fabri);
        Console.WriteLine("Valor de Fábrica: R$" + valor_fabri + " O valor final R$" + valor_total);
        Console.WriteLine("Teste: {0:N2} {1}", valor_fabri,valor_total);
        
    }
}
