namespace Maiornumero;

class Program
{
	static void Main(String[]args)
	{
		int num = 0, Maiornum = 0;
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Digite o {0}° número: ");
			num = int.Parse(Console.ReadLine());
			if (num > Maiornum)
			{
				Maiornum = num;
			}
		}
		Console.WriteLine("{0} foi o maior valor informado.",Maiornum);
	}
}