namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        int c = 0;
        string p = "Americanas";

        Console.WriteLine(p);

        for (int cont = 0; cont < p.Length; cont++)
        {
            char vogal = p[cont];
            if ("aeiou".Contains(vogal))
            {
                Console.WriteLine("Vogal: " + p[cont]);
                c++;
            }

        }
        Console.WriteLine("Total de Vogais: " + c);
    }
}
