using System;
namespace FactoryPattern
{
	public class NoSauce : IPasta
	{
		public NoSauce()
		{
		}

        public void AddSauce()
        {
            Console.WriteLine("No Sauce Selected");
        }
    }
}

