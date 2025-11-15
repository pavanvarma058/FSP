using System.IO;
namespace _1_Cinema_Program_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File Input
            // 1. Cinema Program (Revisited)

            Console.WriteLine("Welcome to NTU cinema!");
            Console.WriteLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int numberOfMovies = 5;

            string[] movieList = new string[numberOfMovies];

            int[] ageRatings = new int[numberOfMovies];

            const string movieListFileName = "Movie-List.txt";

            StreamReader fileReader = new StreamReader(movieListFileName);

            for(int i=0; i<numberOfMovies; i++)
            {
                movieList[i] = fileReader.ReadLine();
                ageRatings[i] = int.Parse(fileReader.ReadLine());
            }
            Console.WriteLine();
       
            
            // Displaying the Movie's List
            for (int i = 0; i < numberOfMovies; i++)
            {
                Console.WriteLine(i + 1 + " " + "-" + " " + movieList[i] + " (" + ageRatings[i] + ")");
                Console.WriteLine();

            }

            // customer choosing the movie
            int film;

            film = readInt("Which film you would like to see: ", 1, 5);

            while (film != 1 && film != 2 && film != 3 && film != 4 && film != 5)
            {
                Console.WriteLine();
                Console.Write("You have entered a wrong number, please enter again: ");
                film = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine((movieList[film - 1]) + " (" + (ageRatings[film - 1]) + ")");

            Console.WriteLine();

            // Checking age of the customer whether his/her age is suitable to watch the film
            bool MovieEntry = false;
            if (age >= ageRatings[film - 1])
            {
                Console.WriteLine("Enjoy the film");
                MovieEntry = true;
            }
            else
            {
                Console.WriteLine("You are too young too watch this film");
            }

            Console.WriteLine();

            // Popcorn will be asked to the customer if his Entry is true 
            if (MovieEntry)
            {
                Console.Write("Do you like to have some popcorn?(Y/N) ");
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
        static int readInt(string prompt, int low, int high)
        {
            int result;
            do
            {
                string intString = readString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high));
            return result;
        }
    }
}
