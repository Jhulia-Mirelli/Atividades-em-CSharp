namespace PalavraReversa;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escreva algo: ");
        string palavra = Console.ReadLine();
        Console.WriteLine(palavra);
        int n = palavra.Length;
        Console.WriteLine(n);
        for (int i = n-1; i >= 0; i--)
        {
            Console.Write(palavra[i]);
        }
    }
}
