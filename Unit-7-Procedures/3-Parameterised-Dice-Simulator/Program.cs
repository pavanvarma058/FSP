namespace _3_Parameterised_Dice_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parameterised Dice Simulator
            rollDice(2);
            rollDice(5);
            rollDice(20);

            Console.ReadLine();
        }
        static void rollDice(int numberOfTimes)
        {
            int total = 0;
            for (int i = 1; i <= numberOfTimes; i++)
            {
                Random random = new Random();
                total += random.Next(1, 6);
            }
            Console.WriteLine(numberOfTimes + " dice rolled: " + total);
        }
    }
}
