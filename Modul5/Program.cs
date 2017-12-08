using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
	class Program
	{
		static void Main(string[] args)
		{
			//5.1
			char sym = 'a';
			for (int i = 0; i < 100; i++)
			{
				Console.Write(sym);
			}
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(sym);
			}

			//5.2
			for (int i = 0; i <= 255; i++)
			{
				Console.WriteLine(i);
			}
			for (int i = 255; i >= 0; i--)
			{
				Console.WriteLine(i);
			}

			//5.3
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			for (int i = a; i <= b; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}


			//5.4
			int counter = 1;
			for (int i = 40; i <= 255; i++)
			{
				Console.Write($"{i,3} -> {(char)i}  ");
				counter++;
				if (counter == 10)
				{
					Console.WriteLine();
					counter = 1;
				}
			}

			//5.5
			int n = int.Parse(Console.ReadLine());
			int res = 0;
			for (int i = 1; i <= n; i++)
			{
				res = res + i;
			}
			Console.WriteLine(res);

			//5.6
			int n = int.Parse(Console.ReadLine());
			int count = n;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write('*');
				}

				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = n - 1; j > i; j--)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}

			//5.7
			Console.Write("Input N: ");
			decimal n = decimal.Parse(Console.ReadLine());
			decimal res = 1;
			while (n >= 2)
			{
				res = res * n;
				n--;
				Console.WriteLine(res);
			}

			//способ через for
			decimal res = 1;
			Console.Write("Input N: ");
			for (int n = int.Parse(Console.ReadLine()); n >= 2; n--)
				{
					res = res * n;
					Console.WriteLine(res);
				}

			//и способ с нормальным подсчётом, где правильно действия проходят
			decimal res = 1;
			Console.Write("Input N: ");
			decimal n = decimal.Parse(Console.ReadLine());
			for (int i = 2; i <= n; i++)
			{
				res *= i;
				Console.WriteLine(res);
			}

			//5.8
			Console.WriteLine("Inpus amount of deposit: ");
			float depSum = float.Parse(Console.ReadLine());
			Console.WriteLine("Input duration of deposit: ");
			int depDur = int.Parse(Console.ReadLine());

			for (int i = 1; i <= depDur; i++)
			{
				depSum = depSum + (depSum / 100 * 20);
				Console.WriteLine(depSum);
			}

			//5.9
			for (int i = 1; i <= 50; i++)
			{
				if (i % 3 == 0 && i % 5 != 0) Console.WriteLine(i);
			}

			//5.10
			int n = int.Parse(Console.ReadLine());
			int temp = 0;
			int average = 0;
			for (int i = 0; i < n; i++)
			{
				int growth = int.Parse(Console.ReadLine());
				temp = temp + growth;
				average = temp / n;
			}
			Console.WriteLine(average);





			//5.11
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				if (i == 1)
				{
					for (int j = 1; j < n; j++)
					{
						Console.Write("*");
					}
				}
				if (i == n)
				{
					for (int j = 1; j < n; j++)
					{
						Console.Write("*");
					}
				}
				Console.WriteLine('*');
			}
			for (int q = 0; q < n; q++)
			{
				Console.SetCursorPosition(n, q + 1);
				Console.WriteLine('*');
			}
			Console.ReadKey();






			//int i = 1;
			//int c = i++ + i++ + ++i + ++i + ++i;
			//Console.WriteLine(c);


			//int a = 0;
			//while (a < 10)
			//{
			//	Console.WriteLine("!!!!!!!!!!");

			//	a++;
			//	Console.WriteLine("awefawef");
			//	if (a == 5)
			//	{
			//		Console.WriteLine("wefwefdc");
			//		break;
			//	}
			//}

			//do
			//{
			//	Console.WriteLine(a);
			//	a++;

			//} while (a < 10);
		}
	}
}
