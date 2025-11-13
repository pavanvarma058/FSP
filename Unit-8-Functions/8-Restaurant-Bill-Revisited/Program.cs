using System.Globalization;

namespace _8_Restaurant_Bill_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Handling Invalid Input
            // 2. Restaurant Bill (Revisited)

            decimal starter = readPositiveDecimal("Enter the cost of the Starter: ");

            Console.WriteLine();

            decimal mainCourse = readPositiveDecimal("Enter the cost of the MainCourse: ");

            Console.WriteLine();

            decimal dessert = readPositiveDecimal("Enter the cost of the Dessert: ");

            Console.WriteLine();

            decimal drinks = readPositiveDecimal("Enter the cost of the Drinks: ");

            Console.WriteLine();

            decimal total = starter + mainCourse + dessert + drinks;
            Console.WriteLine("The total bill is: " + total);

            Console.WriteLine();

            // Enhance your program such that it also reports both how much the bill would be with a 10% tip, and how much with a 20% tip.
            Console.Write("Enter tip percent: ");
            decimal tipPercent = Convert.ToDecimal(Console.ReadLine());

            decimal tipAmount = total * (tipPercent / 100);
            decimal totalWithTip = total + tipAmount;

            Console.WriteLine();

            Console.WriteLine("The total bill with tip is: " + totalWithTip);

            Console.WriteLine();

            // Enhance your program such that it also asks how many people are sharing the cost of the bill, and reports how much each person should pay.
            Console.Write("How many people are sharing the bill: ");
            int share = int.Parse(Console.ReadLine());

            decimal sharedAmount = Convert.ToDecimal(totalWithTip / share);

            Console.WriteLine();

            Console.WriteLine("Each person needs to pay: " + sharedAmount.ToString("C", CultureInfo.GetCultureInfo("en-GB")));
        }
        static string readString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }

        static decimal readPositiveDecimal(string prompt)
        {
            decimal result;

            do
            {
                string inString = readString(prompt);

                if (decimal.TryParse(inString, out result))
                {
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a decimal number.");
                }

            } while (true);
        }
    }
}
