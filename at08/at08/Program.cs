
using System;

namespace at08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num < 0)? "É negativo" : "É positivo");
			
			Console.Write("Pressione algo para sair . . . ");
			Console.ReadKey(true);
		}
	}
}