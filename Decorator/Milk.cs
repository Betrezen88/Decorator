using System;

namespace Decorator
{
	public class Milk : IBeverage, IBeverageAddition
	{
		private IBeverage beverage;
		public IBeverage Beverage
		{
			get { return beverage; }
			set { beverage = value; }
		}

		private string name = ", milk";
		public string Name
		{
			get { return Beverage.Name + name; }
			set { name = value; }
		}

		private float price = 0.5f;
		public float Price
		{
			get { return Beverage.Price + price; }
			set { price = value; }
		}

		public Milk (IBeverage beverage)
		{
			Beverage = beverage;
		}
	}
}

