namespace _6_Dice_Simulator_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dice Simulator Revisited
            //Console.WriteLine("Rolling three dice: " + rollDice(3));

            // 2.3 Task
            //int result = rollDice1(1);
            //Console.WriteLine("The First die rolled: " + result); ;
            //Console.WriteLine("Rolling " + result + " dice resulted in a total of: " + rollDice(result));

            // 2.5 Task
            //Random random = new Random();
            //bool NotSnakeEyes = true;
            //while (NotSnakeEyes)
            //{
            //    int number1 = random.Next(1, 6);
            //    int number2 = random.Next(1, 6);
            //    if(areBothOnes(number1, number2) == false)
            //    {
            //        Console.WriteLine("Snake eyes!");
            //        NotSnakeEyes = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine(number1+number2);
            //    }
            //}

            // 2.4 Task
            Random random = new Random();
            bool NotSnakeEyes = true;
            while (NotSnakeEyes)
            {
                int number1 = random.Next(1, 7);
                int number2 = random.Next(1, 7);
                int sum = number1 + number2;
                if(areBothOnes(number1, number2) == false)
                {
                    Console.WriteLine(sum);
                    Console.WriteLine("Snake eyes!");
                    NotSnakeEyes = false;
                }
                else
                {
                    Console.WriteLine(sum);
                }
                
            }
        }
        static bool areBothOnes(int number1, int number2)
        {
            if(number1 == 1 && number2 == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 2.2 Converting the procedure into a function
        static int rollDice(int numberOfTimes)
        {
            int total = 0;
            Random num = new Random();
            for (int i = 1; i <= numberOfTimes; i++)
            {
                Random random = new Random();
                total += random.Next(1, 6);
            }
            return total;
        }

        
    }
}