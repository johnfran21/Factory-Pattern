using System;
namespace FactoryPattern
{
	public class Pesto : IPasta
	{
		public void AddSauce()
		{
			Console.WriteLine("No Sauce Pasta is Made");
		}
	}
}

