using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
	internal class Program
	{

		class Point
		{
			public double x { get; set; }
			public double y { get; set; }

			public Point(double x, double y)
			{
				this.x = x;
				this.y = y;
			}
			public static Point operator +(Point left, Point right)
			{
				return new Point(left.x + right.x, left.y + right.y);
			}
			public static Point operator -(Point left, Point right)
			{
				return new Point(left.x - right.x, left.y - right.y);
			}
			public static Point operator *(double s, Point point)
			{
				return new Point(s * point.x, s * point.y);
			}
			public static Point operator /(Point left, Point right)
			{
				return new Point(left.x / right.x, left.y / right.y);
			}
			public static bool operator >(Point left, Point right)
			{
				return (left.x > right.x) && (left.y > right.y);
			}
			public static bool operator <(Point left, Point right)
			{
				return (left.x < right.x) && (left.y < right.y);
			}
			public static bool operator true(Point left)
			{
				return (left.x != 0) && (left.y != 0);
			}
			public static bool operator false(Point left)
			{
				return (left.x == 0) && (left.y == 0);
			}
			public static Point operator ++(Point left)
			{
				return new Point(++left.x, ++left.y);
			}
			public static Point operator --(Point left)
			{
				return new Point(--left.x, --left.y);
			}


		}

		static void Main(string[] args)
		{
			Point p1 = new Point(2, 3);
			Point p2 = new Point(7, 8);
			Point p3 = p1 + p2;
			Console.WriteLine($"x = {p3.x} y = {p3.y}");
			Point p4 = p1 - p2;
			Console.WriteLine($"x = {p4.x} y = {p4.y}");
			Point p5 = 3.5 * p1;
			Console.WriteLine($"x = {p5.x} y = {p5.y}");
			Point p6 = p1 / p2;
			Console.WriteLine($"x = {p6.x} y = {p6.y}");
			bool p7 = p1 > p2;
			Console.WriteLine(p7);
			bool p8 = p1 < p2;
			Console.WriteLine(p8);
			p1++;
			++p1;
			Console.WriteLine($"x = {p1.x} y = {p1.y}");
			p2++;
			++p2;
			Console.WriteLine($"x = {p2.x} y = {p2.y}");
			p1--;
			--p1;
			Console.WriteLine($"x = {p1.x} y = {p1.y}");
			p2--;
			--p2;
			Console.WriteLine($"x = {p2.x} y = {p2.y}");
		}
	}
}

