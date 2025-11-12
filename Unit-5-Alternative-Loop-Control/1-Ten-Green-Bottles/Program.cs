namespace _1_Ten_Green_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ten Greeen Bottles 
            int bottles = 10;

            // Used for loop and ternary opeartor
            for(int i=bottles - 1; i>=0; i--)
            {
                string verse = bottles + " green bottle" + (bottles == 1 ? "" : "s") +" sitting on the wall,\n"
                    + bottles + " green bottle" + (bottles == 1 ? "" : "s") + 
                    " sitting on the wall\nand if one green bottle should accidentally fall,\nthere will be " 
                    + i + " green bottle" + (i==1 ? "" : "s") + " sitting on the wall";
                Console.WriteLine(verse);
                bottles--;
                Console.WriteLine();
            }
        }
    }
}
