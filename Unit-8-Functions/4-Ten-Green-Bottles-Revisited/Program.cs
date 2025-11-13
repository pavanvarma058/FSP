namespace _4_Ten_Green_Bottles_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ten Green Bottles Revisited
            Console.Write("Enter the number of bottles: ");
            int bottles = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Choose a colour: ");
            string colour = Console.ReadLine();

            Console.WriteLine();

            // Used for loop and ternary opeartor
            for (int i = bottles - 1; i >= 0; i--)
            {
                string verse = bottles + " " + colour + bottlesText(bottles) + " sitting on the wall,\n"
                    + bottles + " " + colour + bottlesText(bottles) +
                    " sitting on the wall\nand if one " + colour + " bottle should accidentally fall,\nthere will be "
                    + i + " " + colour + bottlesText(i) + " sitting on the wall";
                Console.WriteLine(verse);
                bottles--;
                Console.WriteLine();
            }
        }

        static string bottlesText(int i)
        {
            if(i == 1)
            {
                return " bottle";
            }
            else
            {
                return " bottles";
            }
        }
    }
}
