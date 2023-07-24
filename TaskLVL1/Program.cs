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
		bool quit = false;
		int vx;
		int vy;
		int headX;
		int headY;
		int[,] GameField;//Игровое поле
		int w = 80, h = 40;//ширина и высота игрового поля
		int score = 0;
		int lifes = 3;
		int apples;
		int level = 0;

		void Init()
		{
			Console.CursorVisible = false;
			Console.SetWindowSize(w + 1, h + 3);
			Console.SetBufferSize(w + 1, h + 3);
		}
		void Load (int level=1 )
		{
			int vx= 0;
			int vy= 1;
            int headX= w/2;
			int headY= h/2;
			GameField = new int[w + 1, h + 1];//Создаем игровое поле
			GameField[headX, headY] = 1;//Голова змеи
			Random random = new Random();
			apples = level + 1; 
			//Разбрасываем яблоки
			for (int i = 0; i < apples; i++)
				//Генерируются индексы в массиве и рисуется яблоко
				GameField[random.Next(1, w), random.Next(1, h)] = -1;

			//создаем бардюры
			for(int i=0; i<=w; i++)
			{
				GameField[i, 0] = 10000;
				GameField[i, h] = 10000;
			}
			for (int i = 0; i < h; i++)
			{
				GameField[0, i] = 10000;
				GameField[w, i] = 10000;
			}
		}
		void PrintGameField()
		{
			
			for(int y = 0; y <= h; y++)
				for (int x = 0; x <= w; x++)
				{
					
					Console.SetCursorPosition(x, y + 1);
					
					switch (GameField[x, y])
					{
						case 0: 
							Console.WriteLine(' ');
							break;
						case -1: 
							Console.WriteLine('&');
							break;
                        case 1: 
							Console.WriteLine('1'); 
							break;
						default: Console.WriteLine('#'); 
							break;
					}
				}
			Console.SetCursorPosition(10, 0);
			Console.Write($"Level:{level} Score:{score} Lifes:{lifes} Apples:{apples}");
		}
		void KeyboardUpdate()
		{
			if (Console.KeyAvailable)
			{
				ConsoleKey key = Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: vy--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: vy++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: vx--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: vx++; break;
					case ConsoleKey.Escape: quit = true; break;
					
				}
			}
			
		}
		//Рисование змейки - рекурсивный
		void Next(int tailX, int tailY, int n, int p = 0)
		{
			GameField[tailX, tailY] = n + p;
			if (GameField[tailX + 1, tailY] == n + p) Next(GameField[tailX + 1, tailY], n + 1, p);
			else
			if (GameField[tailX - 1, tailY] == n + p) Next(GameField[tailX - 1, tailY], n + 1, p);
			else
			if (GameField[tailX, tailY - 1] == n + p) Next(GameField[tailX, tailY - 1], n + 1, p);
			else
			if (GameField[tailX, tailY + 1] == n + p) Next(GameField[tailX, tailY - 1], n + 1, p);
			else
				if (p == 0) GameField[tailY, tailX] = 0;
		}
		void Update()
		{
			headX += vx;
			headY += vy;
			if (Collision()) return;
			if (GameField[headX, headY] < 0)
			{
				score++;
				apples--;
				if (apples == 0)
				{
					quit = true;
					return;
				}
				GameField[headX, headY] = 1;
				Next(headX - vx, headY - vy, 1, 1);
			}
			else
				Next(headX, headY, 1, 1);


		}
		bool Collision ()
		{
			if (GameField[headX, headY] > 0) quit = true;
			if (headX < 1 || headX >= w || headY < 1 || headY >= h) quit = true;
			return quit;
		}

		public void Game()
		{
			Init();
			Console.ReadKey();
			while (lifes > 0)
			{
				Load(++level);
				PrintGameField();
				Console.ReadKey();
				while(!quit)
				{
					KeyboardUpdate();
					Update();
					PrintGameField();
				}
				lifes--;
				quit = false;
			}
			
		}
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
			Console.WriteLine($"{grn} грн. {cop} коп.");

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
			Console.WriteLine($"{cost_of_trip} грн.");*/

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

			Program program = new Program();
			program.Game();
			Console.ReadKey();
			/*Console.SetWindowPosition(0, 0);
			Console.BufferWidth = Console.WindowWidth + 1;
			Console.BufferHeight = Console.WindowHeight + 1;
			Console.WriteLine($"Buffer: {Console.BufferWidth} {Console.BufferHeight}");
			Console.WriteLine($"Window: {Console.WindowWidth} {Console.WindowHeight}");


			Random rand = new Random();
			int x = rand.Next(Console.WindowWidth-1);
			int y = rand.Next(Console.WindowHeight-1);
			Console.CursorVisible = false;
			ConsoleKey key;
			do
			{
				int outOfRange = 0;
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
					default: Console.Beep(500, 500); break;
				}
				if (x < 0) { x = 0; outOfRange++; }
				if (y < 0) { y = 0; outOfRange++; }
				
				if (x >= Console.WindowWidth - 1) { x = Console.WindowWidth - 1; outOfRange++; }
				if (y >= Console.WindowHeight - 1) { y = Console.WindowHeight - 1; outOfRange++; }
				if (outOfRange>0) Console.Beep();
				Console.Clear();
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.SetCursorPosition(x, y);
				Console.WriteLine(" ");
				Console.BackgroundColor = ConsoleColor.Black;

				Console.SetCursorPosition(0, 0);
				Console.WriteLine("X = " + x);
				Console.WriteLine("Y = " + y);
				try
				{
					
				}
				catch (Exception e)
				{
					Console.SetCursorPosition(1, Console.BufferHeight - 2);
					Console.WriteLine(e.Message);
					
				}

			} while (key !=ConsoleKey.Escape);*/



		}
	}
}
