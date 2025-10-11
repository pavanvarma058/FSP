using System.Globalization;

namespace _5_Restaurant_Bill_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Restaurant Bill Calculator
            Console.Write("Enter the cost of the Starter: ");
            int starter = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the cost of the MainCourse: ");
            int mainCourse = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the cost of the Dessert: ");
            int dessert = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the cost of the Drinks: ");
            int drinks = int.Parse(Console.ReadLine());

            Console.WriteLine();

            double total = starter + mainCourse + dessert + drinks;
            Console.WriteLine("The total bill is: " + total);

            Console.WriteLine();

            // Enhance your program such that it also reports both how much the bill would be with a 10% tip, and how much with a 20% tip.
            Console.Write("Enter tip percent: ");
            double tipPercent = Convert.ToDouble(Console.ReadLine());

            double tipAmount = total * (tipPercent / 100);
            double totalWithTip = total + tipAmount;

            Console.WriteLine();

            Console.WriteLine("The total bill with tip is: " + totalWithTip);

            Console.WriteLine();

            // Enhance your program such that it also asks how many people are sharing the cost of the bill, and reports how much each person should pay.
            Console.Write("How many people are sharing the bill: ");
            int share = int.Parse(Console.ReadLine());

            decimal sharedAmount = Convert.ToDecimal(totalWithTip / share);

            Console.WriteLine();

            Console.WriteLine("Each person needs to pay: " + sharedAmount.ToString("C", CultureInfo.GetCultureInfo("en-GB")));

            Console.ReadLine();
        }
    }
}
