namespace Vetornome;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        Boolean nomeLista = false;

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine().ToUpper();
        }
        //Verificando se há um nome correspondente
        Console.WriteLine("Digite o nome que deseja procurar: ");
        string nome = Console.ReadLine().ToUpper();

        for (int i = 0; i < nomes.Length; i++)
        {
            if (nome == nomes[i])
            {
                nomeLista = true;
            }
            else
            {
                nomeLista = false;
            }
        }
        if (nomeLista)
        {
            Console.WriteLine("O nome se encontra na lista");
        }
        else
        {
            Console.WriteLine("O nome não se encontra na lista");
        }
    }
}
