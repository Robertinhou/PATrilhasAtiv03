
using System;

namespace at10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número de ponto flutuante");
			float num = float.Parse(Console.ReadLine());
			
			Console.WriteLine((num == 0)? "é igual a 0" : "diferente de 0" );
			
			Console.Write("Pressione algo para sair . . . ");
			Console.ReadKey(true);
		}
	}
}