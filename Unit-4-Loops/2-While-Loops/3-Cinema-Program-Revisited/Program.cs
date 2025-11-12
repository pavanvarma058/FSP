namespace _3_Cinema_Program_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Cinema Program (Revisited)
            Console.WriteLine("Welcome to NTU cinema!");
            Console.WriteLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Currently Showing:");
            Console.WriteLine("1. The Imitation Game (12)");
            Console.WriteLine("2. Ada (13)");
            Console.WriteLine("3. Steve Jobs (15)");

            Console.WriteLine();

            // customer choosing the movie
            Console.Write("Which film you would like to see: ");
            int film = int.Parse(Console.ReadLine());
            while (film != 1 && film != 2 && film != 3)
            {
                Console.WriteLine();
                Console.Write("You have entered a wrong number, please enter again: ");
                film = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            if (film == 1)
            {
                Console.WriteLine("The Imitation Game (12)");
                Console.WriteLine();
                if (age >= 12)
                {
                    Console.WriteLine("Enjoy the film");
                }
                else
                {
                    Console.WriteLine("You are too young too watch this film");
                }
            }
            else if (film == 2)
            {
                Console.WriteLine("Ada (13)");
                Console.WriteLine();
                if (age >= 12)
                {
                    Console.WriteLine("Enjoy the film");
                }
                else
                {
                    Console.WriteLine("You are too young too watch this film");
                }
            }
            else if (film == 3)
            {
                Console.WriteLine("Steve Jobs (15)");
                Console.WriteLine();
                if (age >= 12)
                {
                    Console.WriteLine("Enjoy the film");
                }
                else
                {
                    Console.WriteLine("You are too young too watch this film");
                }
            }

            Console.WriteLine();

            // Popcorn
            Console.Write("Do you like to have some popcorn? ");
            string customer = Console.ReadLine();

            if (customer == "Y")
            {
                Console.WriteLine("Enjoy your popcorn");
            }
            else if (customer == "N")
            {
                Console.WriteLine("Thank you!!");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
