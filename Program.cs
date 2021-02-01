using System;

namespace D3_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[25];

			for (int i = 0; i < numbers.Length; i++)
				numbers[i] = i + 1;

			foreach (int i in numbers)
				Console.WriteLine($"Element value = {i}");
		}
	}
}
