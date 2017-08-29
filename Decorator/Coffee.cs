using System;

namespace Decorator
{
	public class Coffee : IBeverage
	{
		private string name = "Coffee";
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private float price = 1.5f;
		public float Price
		{
			get { return price; }
			set { price = value; }
		}

		public Coffee() {}
	}
}

