namespace _2_Entering_a_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a password
            string newPassword, confirmPassword;

            do
            {
                Console.Write("Create a new password: ");
                newPassword = Console.ReadLine();
                Console.Write("Confirm your password: ");
                confirmPassword = Console.ReadLine();
            } while (newPassword != confirmPassword);
            Console.WriteLine();
            Console.WriteLine("Password created successfully");

            Console.WriteLine();

            // user Log-In
            string loginPassword;

            do
            {
                Console.Write("Enter your password to log-in: ");
                loginPassword = Console.ReadLine();
            } while (loginPassword != confirmPassword);
            Console.WriteLine();
            Console.WriteLine("Log-in successful");
        }
    }
}
