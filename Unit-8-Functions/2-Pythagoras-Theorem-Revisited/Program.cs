namespace _2_Pythagoras_Theorem_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Pythagoras' Theorem (Revisited)
            // Pythagoras' Theorem
            Console.Write("Enter the Length of A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the Length of B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Calculating length of hypotenuse
            
            Console.WriteLine("Length of the Hypotenuse is: " + hypotenuse(a, b));
        }

        static double hypotenuse(double x, double y)
        {
            return Math.Sqrt(sqr(x) + sqr(y));
        }

        static double sqr(double x)
        {
            return x * x;
        }
    }
}
