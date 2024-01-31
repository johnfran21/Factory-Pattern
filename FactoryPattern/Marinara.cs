using System;
namespace FactoryPattern
{
	public class Marinara : IPasta
	{
		public void AddSauce()
		{
			Console.WriteLine("Marinara Pasta is Made");
		}
	}
}

