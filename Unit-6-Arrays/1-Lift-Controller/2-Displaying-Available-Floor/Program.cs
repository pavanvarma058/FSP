namespace _2_Displaying_Available_Floor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Displaying Available Floors

            // Array of floor names
            string[] floorNames = new string[5];
            floorNames[0] = "Ground";
            floorNames[1] = "First";
            floorNames[2] = "Second";
            floorNames[3] = "Third";
            floorNames[4] = "Fourth";

            Console.WriteLine("The available floors are: ");
            for (int i = 0; i < floorNames.Length; ++i)
            {
                Console.WriteLine(i + " " + "-" + " " + floorNames[i]);
                Console.WriteLine();
            }

            // User is asked to choose a floor number
            Console.Write("Choose a floor number: ");
            int floorNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("You have choosen the " + floorNames[floorNumber] + " Floor.");

            
        }
    }
}
