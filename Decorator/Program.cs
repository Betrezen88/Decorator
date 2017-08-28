using System;

namespace Decorator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Coffee coffee = new Coffee();

			Milk milk = new Milk(coffee);

			Sugar sugar = new Sugar (milk);

			Console.WriteLine (sugar.Name() + ", price: " + sugar.Price());
		}
	}
}