namespace _3_A_Non_Numeric_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeatedCharacter = repeatChar('s', 10);
            Console.WriteLine(repeatedCharacter);
        }

        static string repeatChar(char c, int numChars)
        {
            string repeatedChars = "";

            for (int i = 0; i < numChars; ++i)
            {
                repeatedChars += c;
            }

            return repeatedChars;
        }
    }
}
