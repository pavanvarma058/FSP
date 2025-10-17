namespace _2_Quiz_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Welcome to the Quiz");

            Console.WriteLine();
            // Question 1
            Console.WriteLine("Q1: What is 2x2?");
            Console.WriteLine("2");
            Console.WriteLine("4");
            Console.WriteLine("8");
            Console.Write("Enter your answer: ");
            int ans1 = int.Parse(Console.ReadLine());

            if (ans1 == 4)
            {
                count++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.WriteLine();
            // Question 2
            Console.WriteLine("Q2: What is 5x9?");
            Console.WriteLine("42");
            Console.WriteLine("48");
            Console.WriteLine("45");
            Console.Write("Enter your answer: ");
            int ans2 = int.Parse(Console.ReadLine());

            if (ans2 == 45)
            {
                count++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.WriteLine();
            // Question 3
            Console.WriteLine("Q3: What is 95-45?");
            Console.WriteLine("40");
            Console.WriteLine("-25");
            Console.WriteLine("50");
            Console.Write("Enter your answer: ");
            int ans3 = int.Parse(Console.ReadLine());

            if (ans3 == 50)
            {
                count++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine();

            if (count == 3)
            {
                Console.WriteLine("You have answered 3 questions correctly");
            }
            else if (count == 2)
            {
                Console.WriteLine("You have answered 2 questions correctly");
            }
            else if (count == 1)
            {
                Console.WriteLine("You have answered 1 question correctly");
            }
            else
            {
                Console.WriteLine("You have answered 0 question correctly");
            }
        }
    }
}
