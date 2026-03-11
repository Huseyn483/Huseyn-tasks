namespace Nezeride_task;

internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string soz = Console.ReadLine();
		string netice = CumleSoz(cumle, soz);
		Console.WriteLine(netice);
	}

	static string CumleSoz(string metn, string metn1)
	{
		int h = 1;
		for (int i = 0; i <= metn.Length - metn1.Length; i++)
		{
			int say = 0;

			for (int j = 0; j < metn1.Length; j++)
			{
				if (metn[i + j] == metn1[j])
				{
					say++;
				}
			}

			if (say == metn1.Length)
			{
				h = 0;
			}
		}

		if (h == 0)
			return "var";
		else
			return "yoxdur";
	}
}
