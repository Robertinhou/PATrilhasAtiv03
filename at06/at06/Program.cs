
using System;

namespace at06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			if (num % 2 == 0) {
				Console.WriteLine("Seu número é par");
			} else {
				Console.WriteLine("É ímpar");
			}
			
			
			Console.Write("Pressione algo para sair. . . ");
			Console.ReadKey(true);
		}
	}
}