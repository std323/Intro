using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TaskLVL1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region TASK_2
			/*Console.WindowWidth = 120;
			Console.WriteLine($"Тип данных 'short' занимает {sizeof(short)} Байт памяти, и принимает значение в диапазоне от {short.MinValue} до {short.MaxValue}");
			Console.WriteLine($"Переменная типа 'int' занимает {sizeof(int)} Байт памяти, и принимает значение в диапазоне от {int.MinValue} до {int.MaxValue}");
			Console.WriteLine($"Переменная типа 'long' занимает {sizeof(long)} Байт памяти, и принимает значение в диапазоне от {long.MinValue} до {long.MaxValue}");
			Console.WriteLine($"Переменная типа 'float' занимает {sizeof(float)} Байт памяти, и принимает значение в диапазоне от {float.MinValue} до {float.MaxValue}");
			Console.WriteLine($"Переменная типа 'double' занимает {sizeof(double)} Байт памяти, и принимает значение в диапазоне от {double.MinValue} до {double.MaxValue}");
			Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байт памяти, и принимает значение в диапазоне от {decimal.MinValue} до {decimal.MaxValue}");
			*/
			#endregion TASK_2

			#region TASK_3
			//Задача 1
			//double money;
			//int grn, cop;

			/*Console.Write("Введите сумму: ");
			double money = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(money);
			int grn = (int) money;
			int cop = (int)((money - grn) * 100);
			Console.WriteLine($"{grn} грн. {cop} коп.");*/

			//Задача 2
			Console.Write("Цена тетради (грн.): ");
			double price_of_notebook = Convert.ToDouble(Console.ReadLine());
			Console.Write("Количество тетрадей (шт.): ");
			int number_of_notebook = Convert.ToInt32(Console.ReadLine());
			Console.Write("Цена карандаша (грн.): ");
			double price_of_pencil = Convert.ToDouble(Console.ReadLine());
			Console.Write("Количество карандашей (шт.): ");
			int number_of_pencils = Convert.ToInt32(Console.ReadLine());
			double purchase_price = (double)(price_of_notebook * number_of_notebook + price_of_pencil * number_of_pencils);
			Console.Write("Cтоимтость покупки: ");
			Console.WriteLine($"{purchase_price} грн.");

			//Задача 3
			Console.Write("Цена тетради (грн.): ");
			double price_of_copybook = Convert.ToDouble(Console.ReadLine());
			Console.Write("Цена обложки (грн.): ");
			double price_cover = Convert.ToDouble(Console.ReadLine());
			Console.Write("Количество комплектов (шт.): ");
			int number_of_sets = Convert.ToInt32(Console.ReadLine());
			double purchase_price_1 = (price_of_copybook + price_cover) * number_of_sets;
			Console.Write("Cтоимтость покупки: ");
			Console.WriteLine($"{purchase_price_1} грн.");

			//Задача 4
			Console.Write("Расстояние до дачи (км.): ");
			double distance = Convert.ToDouble(Console.ReadLine());
			Console.Write("Расход бензина (литров на 100 км пробега): ");
			double consumption = Convert.ToDouble(Console.ReadLine());
			Console.Write("Цена литра бензина (грн.): ");
			double price_of_fuel = Convert.ToDouble(Console.ReadLine());
			double cost_of_trip = (((distance / 100) * consumption) * price_of_fuel) * 2;
			Console.Write("Поездка на дачу и обратно обойдется в ");
			Console.WriteLine($"{cost_of_trip} грн.");

			#endregion TASK_3

			#region TASK_4
			/*Console.Write("Введите выражение: ");
			string expression = Console.ReadLine();//Читает строку с клавиатуры
			expression = expression.Replace('.', ',');//Replace(что заменит, чем заменить) заменяет первый символ вторым символом в строке
			                                          //В данном случае заменяем ',' на '.'
			String[] values = expression.Split(new char[]{'+', '-', '*', '/'});
			//Метод Split () разделяет строку на подстроки, по указанным разделителям
			//Split() принимает массив char , в котором перечислены разделители,
			//и возвращает массив строк (токенов)
			//Метод Split() не изменяет исходную строку.
			
			double a = Convert.ToDouble(values[0]);
			double b = Convert.ToDouble(values[1]);
			//Метод Contains() проверяет содержит ли исходная строка указанную подстроку.
			if (expression.Contains("+"))Console.WriteLine($"{a}+{b} = {a+b}");
			else if (expression.Contains("-")) Console.WriteLine($"{a}-{b} = {a - b}");
			else if (expression.Contains("*")) Console.WriteLine($"{a}*{b} = {a * b}");
			else if (expression.Contains("/")) Console.WriteLine($"{a}/{b} = {a / b}");
			else Console.WriteLine("No operation");*/
			#endregion TASK_4

			#region SHOOTER
			/*ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch(key)
				{
					case ConsoleKey.W: Console.WriteLine("Вперед"); break;
					case ConsoleKey.S: Console.WriteLine("Назад"); break;
					case ConsoleKey.A: Console.WriteLine("Влево"); break;
					case ConsoleKey.D: Console.WriteLine("Вправо"); break;
					case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
					case ConsoleKey.Enter: Console.Beep(); break;
					default: Console.WriteLine("Error"); break;
				}
			} while (key != ConsoleKey.Escape);*/
			#endregion SHOOTER

			/*Console.CursorTop = 10;
			Console.CursorLeft = 10;
			Console.CursorVisible = false;
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.W: Console.CursorTop++; break;
					case ConsoleKey.S: Console.CursorTop--; break;
					case ConsoleKey.A: Console.CursorLeft--; break;
					case ConsoleKey.D: Console.CursorLeft++; break;
					default: Console.Beep(); break;
				}
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.WriteLine(" ");
				Console.BackgroundColor = ConsoleColor.Black;
			} while (key !=ConsoleKey.Escape);*/



		}
	}
}
