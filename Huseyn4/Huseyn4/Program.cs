namespace Huseyn4;

internal class Program
{
	static void Main(string[] args)
	{
		int[] l = [12, 6, 18, 25, 14];
		int eb = EnBoyuk(l);
		Console.WriteLine(eb);
	}
	static int EnBoyuk(int[] massiv)
	{
		int max = massiv[0];
		for (int i = 1; i < massiv.Length; i++)
		{
			if (massiv[i] > max)
			{
				max = massiv[i];
			}
		}
		return max;
	}
}
