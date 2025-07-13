namespace Web04Ex01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Infome seu peso:");
        float peso = float.Parse(Console.ReadLine());
        Console.Write("Informe sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);

        if (imc < 20)
        {
            Console.WriteLine("Abaixo do peso. IMC: {0:N2}", imc);
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso ideal. IMC: {0:N2}", imc);
        }
        else
        {
            Console.WriteLine("Acima do peso. IMC: {0:N2}", imc);
            }

    }
}


