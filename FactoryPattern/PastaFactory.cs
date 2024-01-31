using System;
namespace FactoryPattern
{
	public static class PastaFactory
	{
		public static IPasta GetSauce(string typeOfSauce)
		{
			switch (typeOfSauce)
			{
				case "Alfredo":
					return new Alfredo();
				case "Marinara":
					return new Marinara();
				case "Pesto":
					return new Pesto();

				default:
					return new NoSauce();


            }
		}
	}
}

