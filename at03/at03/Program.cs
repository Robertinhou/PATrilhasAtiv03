/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at03
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
			
			Console.WriteLine((num1 == num2)? "São iguais" : "São diferentes");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}