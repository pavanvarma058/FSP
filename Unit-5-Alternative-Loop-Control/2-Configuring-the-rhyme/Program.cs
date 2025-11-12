namespace _2_Configuring_the_rhyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.Configuring the Rhyme

            // Asking the user to input number of bottles and choose a colour other than green
            Console.Write("Enter the number of bottles: ");
            int bottles = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Choose a colour: ");
            string colour = Console.ReadLine();

            Console.WriteLine();

            // Used for loop and ternary opeartor
            for (int i = bottles - 1; i >= 0; i--)
            {
                string verse = bottles + " " + colour + " bottle" + (bottles == 1 ? "" : "s") + " sitting on the wall,\n"
                    + bottles + " " + colour + " bottle" + (bottles == 1 ? "" : "s") +
                    " sitting on the wall\nand if one " + colour + " bottle should accidentally fall,\nthere will be "
                    + i + " " + colour + " bottle" + (i == 1 ? "" : "s") + " sitting on the wall";
                Console.WriteLine(verse);
                bottles--;
                Console.WriteLine();
            }
        }
    }
}
