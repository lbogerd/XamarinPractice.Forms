using System;

namespace XamarinPractice.Shared
{
	public static class Randomizer
	{
		public static double GetRandomDouble()
		{
			return new Random()
				.NextDouble();
		}
	}
}
