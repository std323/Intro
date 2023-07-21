using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Point
{

	internal class Point
	{
		public double x;
		public double y;
		public double distance;

		public double get_x()
		{
			return x;
		}
		public double get_y()
		{
			return y;
		}
		public void set_x(double x)
		{
			this.x = x;
		}
		public void set_y(double y)
		{
			this.y = y;
		}
		public Point()
		{
			x = 0;
			y = 0;
		}
		public Point (double x, double y)
		{
			this.x = x;
			this.y = y;
		}
		
		public double Distance(Point other)
		{
			double x_distance = this.x - other.x;
			double y_distance = this.y - other.y;
			distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}
		public static double Distance(Point A, Point B)
		{
			return A.Distance(B); 
		}

		static void Main(string[] args)
		{
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			double distance = A.Distance(B);
			Console.WriteLine($"Расстояние от точки A до точки B: {distance}");
			
			Console.WriteLine($"Расстояние между точками A и B: {A.Distance(B)}");
			Console.WriteLine($"Расстояние между точками B и A: {B.Distance(A)}");


		}
	}
}
