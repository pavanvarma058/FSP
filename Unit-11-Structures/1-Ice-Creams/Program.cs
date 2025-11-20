namespace _1_Ice_Creams
{
    using System;

    // 1.1 Defining a Structure Type
    struct IceCream
    {
        public string flavour;
        public decimal price;
        public int calories;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Ice Creams

            // 1.2 Creating Structures
            IceCream van;
            van.flavour = "Vanilla";
            van.price = 1.99m;
            van.calories = 207;

            IceCream choc;
            choc.flavour = "Chocoloate";
            choc.price = 2.49m;
            choc.calories = 216;

            // 1.3 Displaying Structures
            //Console.WriteLine(van.flavour + " ice cream: " + van.price);

            //displayIceCream(van);
            //Console.WriteLine();
            //displayIceCream(choc);

            //Console.WriteLine();

            //IceCream iceCream = readIceCream();
            //displayIceCream(iceCream);


            // 1.5 Arrays of Structures
            IceCream[] iceCreams = new IceCream[4];
            iceCreams[0] = van;
            iceCreams[1] = choc;
            iceCreams[2] = readIceCream();
            iceCreams[3].flavour = "Strawberry";
            iceCreams[3].price = 2.29m;
            iceCreams[3].calories = 192;

            displayIceCream(iceCreams);
        }

        static void displayIceCream(IceCream[] theIceCream)
        {
            for(int i=0; i<theIceCream.Length; i++)
            {
                Console.WriteLine(theIceCream[i].flavour + " Ice Cream");
                Console.WriteLine("Price: " + theIceCream[i].price);
                Console.WriteLine(theIceCream[i].calories + " Calories");
                Console.WriteLine();
            }
            //Console.WriteLine(theIceCream.flavour + " Ice Cream");
            //Console.WriteLine("Price: " + theIceCream.price);
            //Console.WriteLine(theIceCream.calories + " Calories");
        }

        // 1.4 Returning Structures from Functions
        static IceCream readIceCream()
        {
            Console.Write("Enter a flavour of ice cream: ");
            string flavour = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the price of ice cream: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the calories of ice cream: ");
            int calories = int.Parse(Console.ReadLine());
            Console.WriteLine();
            IceCream theIceCream;

            theIceCream.flavour = flavour;
            theIceCream.price = price;
            theIceCream.calories = calories;

            return theIceCream;
        }
    }
}
