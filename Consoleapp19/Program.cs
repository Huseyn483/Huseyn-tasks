namespace ConsoleApp19;

internal class Program
{
	static void Main(string[] args)
	{
		for (int i = 1; i < 10; i++) //1 ci task
		{
			Console.WriteLine(i);
		}


		int cem = 0;   //2ci task
		for (int i = 1; i < 50; i++)
		{
			cem = cem + i;

		}
		Console.WriteLine(cem);


		for (int i = 10; i > 1; i--) //3cu task
		{
			Console.WriteLine(i);
		}


		int cem1 = 0;                          //4cu task
		for (int i = 2; i < 20; i = i + 2)
		{
			cem1 = cem1 + i;
		}
		Console.WriteLine(cem1);


		for (int i = 1; i < 20; i = i + 2)     //5ci task
		{
			Console.WriteLine(i);
		}

		//6ci task


		int cem2 = 0;     //7ci task
		for (int i = 1; i < 100; i++)
		{
			cem = cem + i;
		}
		Console.WriteLine(cem / 100);


		for (int i = 1; i < 100; i++)      //8ci task
		{
			if (i % 5 == 0 && i % 7 == 0)
			{
				Console.WriteLine(i);
			}
		}



		int cem3 = 0;                        //9cu task
		int cem4 = 0;
		for (int i = 1; i < 10; i++)
		{
			if (i % 2 == 0)
			{
				cem3 = cem3 + i;
			}
			else
			{
				cem4 = cem4 + i;
			}
			Console.WriteLine(cem3 + cem4);

		}


		int bal = int.Parse(Console.ReadLine());   //10cu task
		if (bal > 90)
		{
			Console.WriteLine("A");
		}
		else if (bal > 80 && bal < 90)
		{
			Console.WriteLine("B");
		}
		else if (bal > 70 && bal < 80)
		{
			Console.WriteLine("C");
		}
		else
		{
			Console.WriteLine("Ugursuz");
		}


		int cem5 = 0;                         //11ci task
		int[] arr = [12, 14, 35, 56, 68, 93];

		for (int i = 0; i < arr.Length; i++)
		{
			cem5 = cem5 + arr[i];
		}

		Console.WriteLine(cem5);


		int[] arr1 = [12, 14, 35, 56, 68, 93];        //12ci task

		for (int i = 1; i < arr1.Length; i = i + 2)
		{
			Console.WriteLine(arr1[i]);
		}


		int[] arr2 = [12, 14, 35, 56, 68, 93];        //13cu task

		for (int i = 2; i < arr2.Length; i = i + 2)
		{
			Console.WriteLine(arr2[i]);
		}




		int cem6 = 0;
		int[] arr3 = [12, 14, 35, 56, 68, 93];        //14cu task

		for (int i = 2; i < arr3.Length; i = i + 2)
		{
			cem6 = cem6 + arr3[i];
		}
		Console.WriteLine(cem6);



		int yas = int.Parse(Console.ReadLine());        //15ci task
		if (yas >= 65)
		{
			Console.WriteLine("Pensiya yasina catib");
		}
		else
		{
			Console.WriteLine("Pensiya yasina catmayib");
		}




		int eded = int.Parse(Console.ReadLine());           //16ci task
		if (eded > 0 && eded < 125)
		{
			Console.WriteLine("true");
		}
		else
		{
			Console.WriteLine("false");
		}



		int eded1 = int.Parse(Console.ReadLine());           //17 ci task
		if (eded1 % 2 == 0 && eded1 > 0)
		{
			Console.WriteLine("cutdur");
		}
		else if (eded1 % 2 != 0 && eded1 > 0)
		{
			Console.WriteLine("tekdir");
		}




		int eded2 = int.Parse(Console.ReadLine());           //18 ci task
		if (eded2 % 3 == 0 && eded2 % 5 == 0)
		{
			Console.WriteLine("Eyni anda bolunur");
		}
		else
		{
			Console.WriteLine("Eyni anda bolunmur");
		}




		int eded3 = int.Parse(Console.ReadLine());          //19cu task
		if (eded3 % 2 == 0)
		{
			Console.WriteLine("Bolundu");
		}
		else
		{
			Console.WriteLine("Qaliq hesablanib");
		}




		int eded4 = int.Parse(Console.ReadLine());              //20ci task
		int eded5 = int.Parse(Console.ReadLine());
		if ((eded4 * eded5) > 0)
		{
			Console.WriteLine("Ededin hasili musbetdir");
		}
		else if ((eded4 * eded5) < 0)
		{
			Console.WriteLine("Ededin hasili menfidir");
		}



		Console.Write("Name:");                                //21ci task
		string name = Console.ReadLine();
		Console.Write("Surname:");
		string surname = Console.ReadLine();
		string fullname = name + " " + surname;
		Console.WriteLine(fullname);




		double boy = double.Parse(Console.ReadLine());            //22ci task
		double ceki = double.Parse(Console.ReadLine());
		double bmi = boy / (ceki * ceki);
		if (bmi > 25)
		{
			Console.WriteLine("artiq cekili");
		}
		else if (bmi >= 18.5 && bmi <= 24.9)
		{
			Console.WriteLine("normal");
		}
		else if (bmi < 18.5)
		{
			Console.WriteLine("ariq");
		}



		int fakt = 1;
		int n = int.Parse(Console.ReadLine());
		for (int i = 1; i <= n; i++)
		{
			fakt = fakt * i;
		}
		Console.WriteLine(fakt);




		int[] l = [12, 14, 35, 56, 68, 93];
		int min = l[0]


	}
}