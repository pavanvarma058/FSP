namespace _2_Cinema_Program_Revisited
{
    using System;

    struct Movies
    {
        public string filmName;
        public int ageRating;
        public decimal price;
        public int screenNumber;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Cinema Program (Revisited)
            Console.WriteLine("Welcome to NTU cinema!");
            Console.WriteLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Movies firstMovie;
            firstMovie.filmName = "The Imitation Game";
            firstMovie.ageRating = 12;
            firstMovie.price = 4.5m;
            firstMovie.screenNumber = 4;

            Movies secondMovie;
            secondMovie.filmName = "Ada";
            secondMovie.ageRating = 13;
            secondMovie.price = 5.8m;
            secondMovie.screenNumber = 2;

            Movies thirdMovie;
            thirdMovie.filmName = "Steve Jobs";
            thirdMovie.ageRating = 15;
            thirdMovie.price = 6.0m;
            thirdMovie.screenNumber = 1;

            Movies fourthMovie;
            fourthMovie.filmName = "John Wick";
            fourthMovie.ageRating = 18;
            fourthMovie.price = 6.5m;
            fourthMovie.screenNumber = 5;

            Movies fifthMovie;
            fifthMovie.filmName = "How to Train Your Dragon";
            fifthMovie.ageRating = 10;
            fifthMovie.price = 3.5m;
            fifthMovie.screenNumber = 3;

            Movies[] movies = new Movies[5];
            movies[0] = firstMovie;
            movies[1] = secondMovie;
            movies[2] = thirdMovie;
            movies[3] = fourthMovie;
            movies[4] = fifthMovie;

            Console.WriteLine();

            // Displaying the Movie's List
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + "-" + " " + movies[i].filmName + " (" + movies[i].ageRating + ")");
                Console.WriteLine();

            }

            // customer choosing the movie
            Console.Write("Which film you would like to see: ");
            int film = int.Parse(Console.ReadLine());

            while (film != 1 && film != 2 && film != 3 && film != 4 && film != 5)
            {
                Console.WriteLine();
                Console.Write("You have entered a wrong number, please enter again: ");
                film = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine((movies[film - 1].filmName) + " (" + (movies[film - 1].ageRating) + ")" + " Price: " + movies[film-1].price +
                " Screen Number: " + movies[film-1].screenNumber);

            Console.WriteLine();

            // Checking age of the customer whether his/her age is suitable to watch the film
            bool MovieEntry = false;
            if (age >= movies[film - 1].ageRating)
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
    }
}
