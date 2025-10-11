namespace _4_DoublesVsDecimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double and decimal types can be used to store fractional numbers

            // double is more appropriate for storing physical quantities, such as lengths and weights.
            double pi = 3.14;

            // decimal is more appropriate for storing decimal numbers where precision to a specific number of decimal places is important, such as monetary calculations.
            decimal price = 2.99m;

            decimal fee = 100; // whole number, so 'm' is not needed

            Console.WriteLine(pi);
            Console.WriteLine(price);
            Console.WriteLine(fee);

            Console.ReadLine();
        }
    }
}
