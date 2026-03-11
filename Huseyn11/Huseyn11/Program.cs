namespace Huseyn11;

/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string[] arr = cumle.Split(" ");
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}

*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string[] arr = cumle.Split(" ");
		int say = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			say = say + 1;
		}
		Console.WriteLine(say);
	}
}
*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string soz = Console.ReadLine();
		string yeni = "";
		for (int i = soz.Length - 1; i >= 0; i--)
		{
			yeni = yeni + soz[i];
		}
		if (soz == yeni)
			Console.WriteLine("polindromdur");
		else
			Console.WriteLine("polindrom deyil");
	}
}*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string soz = Console.ReadLine();
		Console.WriteLine(soz.Substring(0, 1));
	}
}
*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string[] arr = cumle.Split(" ");
		int mx = arr[0].Length;
		string maxsoz = arr[0];
		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i].Length > mx)
			{
				mx = arr[i].Length;
				maxsoz = arr[i];
			}

		}
		Console.WriteLine(maxsoz);
	}
}*/

/*
internal class Program
{
	static void Main(string[] args)
	{
		int eded1 = int.Parse(Console.ReadLine());
		int eded2 = int.Parse(Console.ReadLine());
		string operator1 = Console.ReadLine();
		if (operator1 == "+")
			Console.WriteLine(eded1 + eded2);
		else if (operator1 == "-")
			Console.WriteLine(eded1 - eded2);
		else if (operator1 == "/")
			Console.WriteLine(eded1 / eded2);
		else if (operator1 == "+")
			Console.WriteLine(eded1 + eded2);
	}
}
*/


/*internal class Program
{
	static void Main(string[] args)
	{
		int eded = int.Parse(Console.ReadLine());
		int say = 0;
		if (eded < 50)
		{
			for (int i = 3; i <= eded; i++)
			{
				if (i % 3 == 0)
					say = say + 1;
			}
		}
		else if (eded >= 50 && eded <= 100)
		{
			for (int i = 50; i <= eded; i++)
			{
				if (i % 5 == 0)
					say = say + 1;
			}
		}
		else if (eded > 100)
		{
			for (int i = 101; i <= eded; i++)
			{
				if (i % 8 == 0)
					say = say + 1;
			}
		}
		Console.WriteLine(say);
	}
}

*/

/*internal class Program
{
	static void Main(string[] args)
	{
		string[] arr = ["apple", "banana", "mango", "orange"];
		int h = 1;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == "apple")
				h = 0;
		}
		if (h == 0)
			Console.WriteLine("var");
		else
			Console.WriteLine("yoxdu");

	}
}*/



/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string soz = Console.ReadLine();
		int say = 0;
		string[] arr = cumle.Split(" ");
		for (int i = 0; i < arr.Length; i++)
		{
			if (soz == arr[i])
				say = say + 1;
		}
		Console.WriteLine(say);
	}
}*/

