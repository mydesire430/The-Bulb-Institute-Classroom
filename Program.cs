using Microsoft.VisualBasic;

namespace Arrayofstrings.SO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "toyota", "bmw", "ford", "kia" };
            foreach (var car in cars) 
            {
                char lastCharacter = car[car.Length - 1];
                char capitalizeLastCharacter = char.ToUpper(lastCharacter);
             Console.WriteLine(car.Replace(lastCharacter, capitalizeLastCharacter ));
            }
        }
    }
}