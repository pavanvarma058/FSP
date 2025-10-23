namespace _2_Dice_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dice Simulator
            Console.WriteLine("Welcome to Dice Simulator Game :)");

            // Single Dice rolled
            rollDice();
            rollDice();
            rollDice();

            Console.WriteLine();

            // Two Dice rolled
            twoDiceRolled();
            twoDiceRolled();
            twoDiceRolled();

            Console.ReadLine();
        }
        static void rollDice()
        {
            Random num = new Random();
            int number = num.Next(1, 6);
            Console.WriteLine("Dice rolled: " + number);
        }

        static void twoDiceRolled()
        {
            Random random = new Random();
            int number1 = random.Next(1, 6);
            int number2 = random.Next(1, 6);
            int total = number1 + number2;
            Console.WriteLine("Two Dice rolled: " + total);
        }
    }
}
