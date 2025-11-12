namespace _2_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entering a password (Revisited)
            // creating a password
            Console.Write("Create a new password: ");
            string newPassword = Console.ReadLine();
            Console.Write("Confirm your new password: ");
            string confirmPassword = Console.ReadLine();

            Console.WriteLine();

            while(newPassword != confirmPassword)
            {
                Console.Write("Passwords do not match, try again: ");
                newPassword = Console.ReadLine();

                Console.Write("Confirm your password: ");
                confirmPassword = Console.ReadLine();

                Console.WriteLine();
            }
            Console.WriteLine("Password created successfully");

            Console.WriteLine();

            // user login
            Console.Write("Enter your password to Log-In: ");
            string password = Console.ReadLine();

            Console.WriteLine();

            while (password != confirmPassword)
            {
                Console.Write("Incorrect password, try again: ");
                Console.WriteLine();
                password = Console.ReadLine();
            }
            Console.WriteLine("Log-In successful");
        }
    }
}
