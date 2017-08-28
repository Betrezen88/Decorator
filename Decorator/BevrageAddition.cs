using System;

namespace Decorator
{
	public abstract class BeverageAddition : Beverage
	{
		private Beverage m_beverage;

		public BeverageAddition(Beverage beverage) { m_beverage = beverage; }

		public Beverage Base
		{
			get { return m_beverage; }
		}

		public abstract override String Name();
		public abstract override float Price();
	}
}