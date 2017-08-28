using System;

namespace Decorator
{
	public class Coffee : Beverage
	{
		public Coffee () {}

		public override String Name()
		{
			return "Coffee";
		}

		public override float Price()
		{
			return 1.5f;
		}
	}
}

