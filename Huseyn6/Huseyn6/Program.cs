namespace Huseyn6;

internal class Program
{
	static void Main(string[] args)
	{
		int a = 5;
		int b = 6;
		string metod = Muqayise(a, b);
		Console.WriteLine(metod);
	}
	static string Muqayise(int c, int d)
	{
		int hasil = c * d;
		int cem = c + d;
		if (hasil > cem)
		{
			return "hasil cemden boyukdur";
		}
		else if (cem > hasil)
		{
			return "Cem hasilden boyukdur";
		}
		else
		{
			return "Cem ile hasl beraberdir";
		}
	}
}
