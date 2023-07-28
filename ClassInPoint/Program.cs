using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInPoint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point point = new Point(5, 2);
			//point.X = 2000;
			//point.Y = 3000;
			Console.WriteLine($"X = " + point.X + "\tY = " + point.Y);
			point.print();
			Console.WriteLine(point);
			Console.WriteLine(((Object)2).ToString());
		}
	}
}
