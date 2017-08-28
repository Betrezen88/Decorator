using System;

namespace Decorator
{
	public class Sugar : BeverageAddition
	{
		public Sugar (Beverage beverege) : base(beverege) {}

		public override string Name()
		{
			return Base.Name () + ", sugar";
		}

		public override float Price()
		{
			return Base.Price () + 0.1f;
		}
	}
}

