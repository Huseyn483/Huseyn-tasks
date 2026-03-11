namespace Huseyn10;

/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		int say = 0;
		for (int i = 0; i < cumle.Length; i++)
		{
			say = say + 1;
		}
		Console.WriteLine(say);
	}
}*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		Console.WriteLine(cumle.ToUpper());
		Console.WriteLine(cumle.ToLower());
	}
}*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		Console.WriteLine(cumle.Trim());
	}
}
*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string herf = Console.ReadLine();
		Console.WriteLine(cumle.IndexOf(herf));
		Console.WriteLine(cumle.LastIndexOf(herf));
	}
}*/



/*internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		Console.WriteLine(cumle.Replace("salam", "sagol"));
	}
}


*/


/*
internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string[] yeni = cumle.Split(",");
		for (int i = 0; i <= yeni.Length; i++)
		{
			Console.WriteLine(yeni[i]);
		}
	}
}
*/


/*internal class Program
{
	static void Main(string[] args)
	{
		string email = Console.ReadLine();
		int inx = email.IndexOf("@");
		string yeni = "";
		for (int i = 0; i < inx; i++)
		{
			yeni = yeni + email[i];
		}
		Console.WriteLine(yeni);
	}
}

*/



/*internal class Program
{
	static void Main(string[] args)
	{
		string metn = Console.ReadLine();

		if (metn.Trim() == "")
		{
			Console.WriteLine("Metn bosdu yada bosluqlardan ibaretdir");
		}
		else
		{
			Console.WriteLine(metn);
		}
	}
}
*/



/*internal class Program
{
	static void Main(string[] args)
	{
		static void Main(string[] args)
		{
			string metn = Console.ReadLine();

			metn = metn.ToLower(); 
			string netice = char.ToUpper(metn[0]) + metn.Substring(1);
			Console.WriteLine(netice);
		}
	}
}

*/

/*internal class Program                           //sora baxmaq
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		string[] arr = cumle.Split(" ");
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i].Reverse());
		}
	}
}*/
