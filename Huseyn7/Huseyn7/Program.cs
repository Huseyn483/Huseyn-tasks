namespace Huseyn7;

internal class Program
{
	static void Main(string[] args)
	{
		int[] l = [7, 9, 11, 24, 36];
		int eded = int.Parse(Console.ReadLine());
		string netice = TrueFalse(l, eded);
		Console.WriteLine(netice);
	}
	static string TrueFalse(int[] arr, int a)
	{
		int h = 1;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == a)
			{
				h = 0;
			}
		}
		if (h == 0)
		{
			return "eded massivde var";
		}
		else
		{
			return "eded massivde yoxdur";
		}
	}
}
