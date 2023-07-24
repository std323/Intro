using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{

		static void Main(string[] args)
		{
			#region ARRAYS_1
			/*Console.Write("Ведите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new int[n];
			int[] arr;
			 arr = new int[n];
			//Заполнение массива случайными числами:
			//1) Создаем обьект класа Random:
			Random rand = new Random(0);
			for(int i = 0; i< arr.Length; i++)
			{
				arr[i] = rand.Next(100, 200);
			}
			//Вывод массива на экран:
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			//Сумма 
			Console.WriteLine($"Cумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Cреднее-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение массива: {arr.Min()}");
			Console.WriteLine($"Максимальное значение массива: {arr.Max()}");
			Array.Sort(arr);

			foreach(int i  in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

			arr = arr.Concat(new int[] { 123 }).ToArray();
			foreach (int i in arr)Console.Write(i + "\t");Console.WriteLine();*/


			#endregion ARRAYS_1

			#region ARRAYS_2
			/*//Console.Write("Введите количество строк: ");
			//int  rows= Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов строки: ");
			//int cols= Convert.ToInt32(Console.ReadLine());
			//int[,] i_arr_2 = new int[rows, cols];
			int[,] i_arr_2 = new int[,]
			{
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9}
			};
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();

			}
			//int rows = i_arr_2.GetUpperBound(0) + 1;
			//int cols = i_arr_2.GetUpperBound(1) + 1;
			//for(int i = 0; i < rows; i++)
			//{
				//for(int j = 0; j < cols; j++)
				//{
					//Console.Write(i_arr_2[i, j] + "\t");
				//}
				//Console.WriteLine();
			//}

			Console.WriteLine(i_arr_2.Length);
			Console.WriteLine(i_arr_2.Rank);
			Console.WriteLine(i_arr_2.GetLength(0));
			Console.WriteLine(i_arr_2.GetLength(1));

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			//foreach (ref int i in i_arr_2)
			//{
				//i = rand.Next(100);
			//}
			//Console.WriteLine();
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();

			}

			//int sum = 0;
			//for(int i=0; i< i_arr_2.GetLength(0); i++)
			//{
			//for(int j=0; j< i_arr_2.GetLength(1); j++)
			//{
			//sum += i_arr_2[i, j];
			//}
			//}
			//Console.WriteLine($"Cумма элементов массива: {sum}");

			Console.WriteLine($"Cумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Cреднее-арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
			Console.WriteLine($"Минимальное значение массива:  {i_arr_2.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное значение массива: {i_arr_2.Cast<int>().Max()}");*/
			#endregion ARRAYS_2

			#region RAGGED_ARRAY
			/*//Console.Write("Введите количество строк: ");
			//int  rows= Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов строки: ");
			//int cols= Convert.ToInt32(Console.ReadLine());
			int[][] ragged_arr = new int[5][];//Обьявляем массив указателей (ссылок)
			ragged_arr[0] = new int[] { 0, 1, 1, 2 };
			ragged_arr[1] = new int[] { 3, 5, 8 };
			ragged_arr[2] = new int[] { 13, 21, 34, 55, 89 };
			ragged_arr[4] = new int[] { 144, 233, 377 };

			//for (int i=0; i< ragged_arr.Length; i++)
			//{
			//ragged_arr[i] = new int[cols];
			//}

			Random rand = new Random(0);
			//for (int i = 0; i < ragged_arr.Length; i++)
			//{
			//for (int j = 0; j < ragged_arr[i].Length; j++)
			//{
			//ragged_arr[i][j] = rand.Next(100);
			//}
			//}
			//for( int i=0;  i < ragged_arr.Length; i++)
			//{
			//for (int j = 0; j < ragged_arr[i].Length; j++)
			//{
			//Console.Write(ragged_arr[i][j] + "\t");
			//}
			//Console.WriteLine();
			//}
			foreach (int[] i in ragged_arr)//Итератор 'i' перебирает массивы
			{
				if (i != null)
				{
					foreach (int j in i)//Итератор 'j' перебирает элементы массива
					{
						Console.Write(j + "\t");
					}
					Console.WriteLine();
				}
				else
				{
					Console.WriteLine("Строка пустая");
				}
			}

			//Сумма элементов массива:
			int sum = 0;
			int count = 0;
			foreach (int[] i in ragged_arr)// Итератор 'i' перебирает массивы
			{
				if (i != null)
				{
					sum += i.Sum();
					count += i.Length;
				}
			}
			Console.WriteLine($"Cумма элементов массива: {sum}");
			Console.WriteLine($"Среднее-арифметическое: {(double)sum / count}");

			// Минимальное и максимальное значение массива:
			int Min = 0;
			int Max = 0;
			for (int i = 0; i < ragged_arr.Length; i++)
			{
				if (ragged_arr[i] != null)
				{
					for (int j = 0; j < ragged_arr[i].Length; j++)
					{
						if (Min > ragged_arr[i][j]) Min = ragged_arr[i][j];
						if (Max < ragged_arr[i][j]) Max = ragged_arr[i][j];
					}
				}
			}
			Console.WriteLine($"Минимальное значение массива: {Min}");
			Console.WriteLine($"Максимальное значение массива: {Max}");*/

			#endregion RAGGED_ARRAY

			#region ENUM

			/*//Week day = Week.Sunday;
			//Console.WriteLine(day);
			//Console.WriteLine(Enum.GetUnderlyingType(typeof(Week)));

			string[] dayName = Enum.GetNames(typeof(Week));
			int[] dayNumber = (int[])Enum.GetValues(typeof(Week));
			for(int i=0; i < dayNumber.Length; i++)
			{
				Console.WriteLine($"Name: {dayName[i]}, \t- Value: {dayNumber[i]}");
			}
			Console.WriteLine(delimiter);

			string[] distName = Enum.GetNames(typeof(DistanceFromSun));
			ulong[] distValue = (ulong[])Enum.GetValues(typeof(DistanceFromSun));
			for(int i=0; i < distName.Length; i++)
			{
				Console.WriteLine($"Name: {distName[i]}\t= {distValue[i]}");
			}
			Console.WriteLine($"Type: {Enum.GetUnderlyingType(typeof(DistanceFromSun))}");

			

		}
		const string delimiter = "\n---------------------------------\n";
			enum Week: uint
			{
				Sunday = 0,
				Monday = 1,
				Tuesday = 2,
				Wednesday = 3,
				Thursday = 4,
				Friday = 5,
				Saturday = 6,
			};
		enum DistanceFromSun : ulong
		{
			Sun =0,
			Mercury = 57900000,
			Venus = 108200000,
			Earth = 149600000,
			Mars = 227900000,
			Jupiter = 7783000000,
			Saturn = 1427000000,
			Uranus = 2870000000,
			Neptune = 4496000000,
			Pluto = 594600000

		}*/
			#endregion ENUM
		}
	}
	}

	

	

