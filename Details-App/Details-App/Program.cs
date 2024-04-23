using System;

namespace Details_App
{
    public class Program
    {
      
        static void Main(string[] args)
        {

            //This recieves the details from the console
            Console.WriteLine("Enter the book title");
            var title = Console.ReadLine();
            Console.WriteLine("Enter the book description");
            var description = Console.ReadLine();
            Console.WriteLine("Enter a price");
            var price = int.Parse(Console.ReadLine());



            var details = new BookDetails(title, description, price);
            var endResult = details.ReturnDetails();
            Console.WriteLine(endResult);

        }
    }
}
