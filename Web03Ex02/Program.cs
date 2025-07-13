namespace Web03Ex02;

class Program
{
    static void Main(string[] args)
    {
        //pegando dados velocidade
        Console.Write("Velocidade em KM: ");
        double velocidade = double.Parse(Console.ReadLine());

        //Processando dados
        if (velocidade > 60)
        {
            Console.WriteLine("MULTADO! Velocidade acima do permitido!");
        }
        else
        {
            Console.WriteLine("Velocidade no limite esperado");
        }
    }
}
