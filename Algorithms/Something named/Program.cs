using System.ComponentModel.Design;

namespace Something_named
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please enter in a time in hours (1-12): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in a time in minutes (0-60): ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in a time in seconds (0-60): ");
            int seconds = Convert.ToInt32(Console.ReadLine());  

        }
    }
}