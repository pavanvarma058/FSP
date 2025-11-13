namespace Month_Names_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Month Names

            // 2. Separating Interface from Internals

            string[] monthNames =
                    { "January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("The months are: ");
            for (int i = 0; i < monthNames.Length; ++i)
            {
                Console.WriteLine(i+1 + " " + "-" + " " + monthNames[i]);
                Console.WriteLine();
            }

            // Asking user to input a month number
            Console.Write("Choose a month number: ");
            int monthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("You have choosen " + monthNames[monthNumber-1]);
        }
    }
}
