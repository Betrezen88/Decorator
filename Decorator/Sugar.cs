using System;

namespace Decorator
{
	public class Sugar : IBeverage, IBeverageAddition
	{
		private IBeverage beverage;
		public IBeverage Beverage
		{
			get { return beverage; }
			set { beverage = value; }
		}

		private string name = ", sugar";
		public string Name
		{
			get { return Beverage.Name + name; }
			set { name = value; }
		}

		private float price = 0.1f;
		public float Price
		{
			get { return Beverage.Price + price; }
			set { price = value; }
		}

		public Sugar (IBeverage beverage)
		{
			Beverage = beverage;
		}
	}
}

