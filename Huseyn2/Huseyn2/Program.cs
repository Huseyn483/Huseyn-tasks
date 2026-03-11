namespace Huseyn2;

internal class Program
{
	static void Main(string[] args)
	{
		string cumle = Console.ReadLine();
		int result = SimvolSayi(cumle);
		Console.WriteLine(result);
	}
	static int SimvolSayi(string cumle)
	{
		int say = 0;
		for (int i = 0; i < cumle.Length; i++)
		{
			say = say + 1;

		}
		return say;
	}
}
