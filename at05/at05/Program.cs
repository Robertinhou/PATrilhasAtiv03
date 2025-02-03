
using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números de ponto flutuantes ");
			Console.Write("N°1: ");
			float num1 = float.Parse(Console.ReadLine());
			
			Console.Write("N°2: ");
			float num2 = float.Parse(Console.ReadLine());
			
			
			Console.WriteLine((num1 >= num2)? "É Maior ou igual" : "Não é Maior ou igual");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}