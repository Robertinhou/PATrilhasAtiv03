
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números");
			Console.Write("N° 1: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("N° 2: ");
			int num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("O menor número: "+  Math.Min(num1, num2));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}