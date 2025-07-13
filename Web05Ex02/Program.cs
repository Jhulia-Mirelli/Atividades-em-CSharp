namespace Web05Ex02;

class Program
{
    static void Main(string[] args)
    {
        //CHAMADA DE FUNÇÃO
        mensagem();
        Console.Write("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Fatorial de " + n + " = " + calFatorial(n));
    }
    //DECLARANDO FUNÇÕES
    static void mensagem()
    {
        Console.WriteLine("----FATORIAL----");

    }

    static int calFatorial(int n)
    {
        int fat = 1;
        for (int i = 1; i <= n; i++)
        {
            fat *= i;
        }
        return fat;
    }

}