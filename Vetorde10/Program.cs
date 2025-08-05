namespace Vetorde10;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int somaPar = 0, somaImpar = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o {i + 1}°: ");
            int n = Convert.ToInt32(Console.ReadLine());
            vetor[i] = n;
            if (n % 2 == 0)
            {
                somaPar++;
            }
            else
            {
                somaImpar++;
            }
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"|{vetor[i]}|");
        }
        Console.WriteLine($"\nTotal de valores pares digitados: {somaPar}");
        Console.WriteLine($"Total de valores impares digitados: {somaImpar}");
    }
}
