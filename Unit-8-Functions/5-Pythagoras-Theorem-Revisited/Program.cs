namespace _5_Pythagoras_Theorem_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            consoleReadWriteHypotenuseIsosceles();
            consoleReadWriteHypotenuseScalene();
        }

        static void consoleReadWriteHypotenuseScalene()
        {
            Console.Write("Enter the base length of the right-angled triangle: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.Write("Enter the side length of the right-angled triangle: ");
            double sideLength = double.Parse(Console.ReadLine());
            Console.WriteLine("The hypotenuse is: " + hypotenuse(baseLength, sideLength));
        }

        static void consoleReadWriteHypotenuseIsosceles()
        {
            Console.Write("Enter the leg length of an isosceles right-angled triangle: ");
            double legLength = double.Parse(Console.ReadLine());
            Console.WriteLine("The hypotenuse is: " + hypotenuse(legLength, legLength));
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
