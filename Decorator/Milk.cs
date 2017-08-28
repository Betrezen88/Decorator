using System;

namespace Decorator
{
	public class Milk : BeverageAddition
	{
		public Milk(Beverage beverage) : base(beverage)
		{

		}

		public override String Name()
		{
			return Base.Name () + ", milk";
		}

		public override float Price ()
		{
			return Base.Price() + 0.5f;
		}
	}
}

