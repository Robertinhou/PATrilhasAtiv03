/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 10:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite três números inteiros");
			Console.Write("N° 1: ");
			int num1 = int.Parse(Console.ReadLine());
			
			Console.Write("N° 2: ");
			int num2 = int.Parse(Console.ReadLine());
			
			Console.Write("N° 3: ");
			int num3 = int.Parse(Console.ReadLine());
			
			if (num1 < num2 && num1 > num3) {
				Console.WriteLine("É maior");
			} else{
				Console.WriteLine("Falso");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}