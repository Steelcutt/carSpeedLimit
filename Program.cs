using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSpeedLimit
{
	public class Car
	{
		public string make, model, mph_string;
		public int speed;

		Car()
		{
			
			Console.WriteLine("Enter the Make of the vehicle : ");
			this.make = Console.ReadLine();
			 
			Console.WriteLine("Enter the Model of the vehicle :  ");
			this.model = Console.ReadLine();
			
			Console.WriteLine("Enter the speed of the vehicle :  ");
			this.mph_string = Console.ReadLine();

			this.speed = Convert.ToInt16(mph_string);
		}

		void Check_car(int limit)
		{
			int demerits;
			if (this.speed < limit)
			{
				Console.WriteLine(this.make + " " + this.model + " " + this.mph_string + " mph : OK ");
				return;
			}
			else
			{
				demerits = (this.speed - limit) / 5;
				if (demerits >= 10)
				{
					Console.WriteLine(this.make + " " + this.model + " " + this.mph_string + " mph : " + demerits.ToString() + "\n demerits = <LICENSE SUSPENDED>");
					return;
				}
				else
				{
					Console.WriteLine(this.make + " " + this.model + " " + this.mph_string + " mph : " + demerits.ToString() + "\n demerits ");
					return;
				}
			}

		}

		public static void Main(string[] args)
		{
			int speed_limit_int = 40;

			Car vehicle1 = new Car();
			Car vehicle2 = new Car();
			Car vehicle3 = new Car();
			Console.WriteLine("\n");

			Console.WriteLine("Speed Limit: 40mph");
			
			Console.WriteLine("\n");
			
			vehicle1.Check_car(speed_limit_int);
			Console.WriteLine("\n");
			vehicle2.Check_car(speed_limit_int);
			Console.WriteLine("\n");
			vehicle3.Check_car(speed_limit_int);


		}
	}
}