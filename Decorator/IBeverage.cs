using System;

namespace Decorator
{
	public interface IBeverage
	{
		string Name { set; get; }
		float Price { set; get; }
	}
}