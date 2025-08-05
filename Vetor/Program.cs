namespace Vetor;

class Program
{
    static void Main(string[] args)
    {
        //criar um vetor com 5 posições
        int[] vetor = new int[5];
        //atribuindo valor
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}° valor: ");
            int n = Convert.ToInt32(Console.ReadLine());
            vetor[i] = n;
        }
        //mostrando os valores
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"|{vetor[i]}|");
        }

    }
}
