namespace _3_Pythagors_Theorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pythagoras' Theorem
            Console.Write("Enter the Length of A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the Length of B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Calculating length of hypotenuse
            double h = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("Length of the Hypotenuse is: " + h);

            Console.ReadLine();
        }
    }
}
