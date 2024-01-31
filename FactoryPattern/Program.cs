namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IPasta alfredoPasta = PastaFactory.GetSauce("Alfredo");
            //IPasta marinaraPasta = PastaFactory.GetSauce("Marinara");
            //IPasta noSaucePasta = PastaFactory.GetSauce("No Sauce");

            //AddSauceToPasta(alfredoPasta);
            //AddSauceToPasta(marinaraPasta);
            //AddSauceToPasta(noSaucePasta);

            Console.WriteLine("What type of sauce would you like?");
            string userInput = Console.ReadLine();

            IPasta pastaSauce = PastaFactory.GetSauce(userInput);

            pastaSauce.AddSauce();

           

        }
    }
}
