namespace Huseyn5;

internal class Program
{
	static void Main(string[] args)
	{
		double result = CalculateAverage(5, 7, 6);
		Console.WriteLine(result);
	}
	static double CalculateAverage(int a, int b, int c)
	{
		return (a + b + c) / 3;
	}
}
