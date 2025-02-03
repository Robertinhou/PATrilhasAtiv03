using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números");
			Console.Write("n°1: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("n°2: ");
			int num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("O maior número é:" + Math.Max (num1, num2));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}