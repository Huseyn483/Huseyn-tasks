namespace Huseyn8;

internal class Program
{
	static void Main(string[] args)
	{
		int[] arr = [12, 36, 8, 9, 7];
		int netice = EnKicik(arr);
		Console.WriteLine(netice);
	}
	static int EnKicik(int[] massiv)
	{
		int min = massiv[0];
		for (int i = 1; i < massiv.Length; i++)
		{
			if (massiv[i] < min)
			{
				min = massiv[i];
			}
		}
		return min;
	}
}
