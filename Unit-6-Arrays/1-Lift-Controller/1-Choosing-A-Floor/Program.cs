namespace _1_Choosing_A_Floor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lift Controller

            // User is asked to choose a floor number
            Console.Write("Choose a floor number: ");
            int userEntered = int.Parse(Console.ReadLine());

            // Array of floor names
            string[] floorNames = new string[5];
            floorNames[0] = "Ground";
            floorNames[1] = "First";
            floorNames[2] = "Second";
            floorNames[3] = "Third";
            floorNames[4] = "Fourth";

            Console.WriteLine("You have choosen the " + floorNames[userEntered] + " Floor.");
        }
    }
}
