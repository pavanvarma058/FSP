using System.IO;
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

            const string scoresFileName = "scores.txt";
            StreamWriter scoreFile = new StreamWriter(scoresFileName, append: true);

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
                Console.Write("Enter your answer: ");
                int ans = int.Parse(Console.ReadLine());

                if (ans == correctAnswers[i])
                {
                    Console.WriteLine("Correct");
                    count++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine();
            }

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            string quizResult = userName + ": " + count + "/3";

            scoreFile.WriteLine(quizResult);
            scoreFile.Close();
        }
    }
}
