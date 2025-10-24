namespace _4_Railway_Train_Departures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Railway Train Departures
            string[] stationCodes = { "LON", "NOT", "BHM", "MAN", "CDF", "EDB", "GLC", "LDS" };

            int[] scheduledHours = { 08, 09, 11, 13, 15, 18, 21, 23 };

            int[] scheduledMinutes = { 05, 45, 23, 01, 27, 05, 48, 55 };

            int[] lateMinutes = { 8, 0, 37, 6, 0, 0, 20, 9 };

            Console.WriteLine("Destination   Scheduled   Expected");

            for (int i = 0; i < stationCodes.Length; ++i)
            {
                Console.Write("    ");
                Console.Write(stationCodes[i]);
                Console.Write("         ");
                writeTime(scheduledHours[i], scheduledMinutes[i]);
                Console.Write("      ");

                int expectedMinutes = scheduledMinutes[i] + lateMinutes[i];
                writeTime(scheduledHours[i], expectedMinutes);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        // 3. Improving Code Quality with a Procedure
        // 4. Displaying Time
        static void writeTime(int hours, int minutes)
        {
            int actualMinutes = minutes % 60;
            int actualHours = (hours + (minutes / 60)) % 24;

            string hoursFormat = string.Format("{0:00}", actualHours);
            string minutesFormat = string.Format("{0:00}", actualMinutes);
            Console.Write(hoursFormat + ":" + minutesFormat);
        }
    }
}
