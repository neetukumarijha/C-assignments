using System;

namespace Sumofarray
{
	class SumOfAllArrayElements
	{

		public void calculateSumOfArrayElements(int[] array)
		{

			int sum = 0;
			foreach (int item in array)
			{
				sum += item;
			}

			Console.WriteLine("Sum of all the elements in the array is : " + sum);
		}
	}

	class DriverProgram
	{

		static void Main(String[] args)
		{

			int[] newarray = { 10, 20, 30, 40, 50 };

			SumOfAllArrayElements obj1 = new SumOfAllArrayElements();
			obj1.calculateSumOfArrayElements(newarray);

			ConsoleKeyInfo status;

			Console.WriteLine("\n\n Do You Want To Break (Y/y)");
			status = Console.ReadKey();
			if (status.Key == ConsoleKey.Y)
			{
				Console.Clear();
			}

		}
	}
}