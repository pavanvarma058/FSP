namespace _1_Defining_A_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining a Function
            double x = sqr(7);
            Console.WriteLine(x);

        }

        static double sqr(double x)
        {
            return x * x;
        }
    }
}
