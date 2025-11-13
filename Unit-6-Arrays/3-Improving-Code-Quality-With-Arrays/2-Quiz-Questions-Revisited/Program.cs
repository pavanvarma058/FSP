namespace _2_Quiz_Questions_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Quiz Questions (Revisited)
            int count = 0;
            Console.WriteLine("Welcome to the Quiz");

            Console.WriteLine();

            string[] quizQuestions = { "Q1: What is 2x2?\n2\n4\n8", "Q2: What is 5x9?\n42\n48\n45", "Q3: What is 95-45?\n40\n-25\n50" };
            int[] correctAnswers = { 4, 45, 50 };

            for(int i=0; i<quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
                Console.Write("Enter your answer: ");
                int ans = int.Parse(Console.ReadLine());
                if(ans == correctAnswers[i])
                {
                    Console.WriteLine("Correct");
                    count++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }

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
