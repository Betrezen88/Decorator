using System;

namespace Decorator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			 var coffee = new Coffee ();
			 var milk = new Milk (coffee);
			 var sugar = new Sugar (milk);

			Console.WriteLine (sugar.Name + ", price: " + sugar.Price);
		}
	}
}