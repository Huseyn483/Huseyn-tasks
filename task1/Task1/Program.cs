namespace Task1;

/*internal class Program
{
	public static void Main(string[] args)
	{
		string soz = Console.ReadLine();
		int h = 1;
		int s = 1;
		int f = 1;
		for (int i = 0; i < soz.Length; i++)
		{
			if (char.IsUpper(soz[i]))
			{
				h = 0;
			}
			else if (char.IsLower(soz[i]))
			{
				s = 0;
			}
			else if (char.IsDigit(soz[i]))
			{
				f = 0;
			}
		}

		if (f == 0 && s == 0 && h == 0)
		{
			Console.WriteLine("Sertleri odeyir");
		}
		else
		{
			Console.WriteLine("Sertleri odemir");
		}
	}
}*/



/*internal class Program
{
	public static void Main(string[] args)
	{
		string cumle = "Salam Sagol";
		Console.WriteLine(TrueFalse(cumle));
	}
	static string TrueFalse(string metn)
	{
		string[] arr = metn.Split(" ");

		if (arr.Length == 2 && char.IsUpper(arr[0][0]) && char.IsUpper(arr[1][0]))
		{
			return "Sert odenir";
		}
		else
		{
			return "Sert odenmir";
		}
	}
}*/

