using System;

namespace Module3Lecture2
{
    class Program
    {

        static int AskForPurchase(int ounces)
        {
            int count = 0;
            Console.WriteLine($"Would you like to buy {ounces}oz jars? y/n");
            char answer = Console.ReadLine().ToLower()[0];

            // if (answer == 'y') 
            //     count = GetJarsCount(ounces);

            count = (answer == 'y') ? GetJarsCount(ounces);
            
            return count;
        }

        static int GetJarsCount(int ounces)
        {
            int count = 0;
            Console.WriteLine($"How many {ounces}oz jars>");
            count = Convert.ToInt32(Console.ReadLine());
            
            return count;
        }
        
        static void Main(string[] args)
        {
           /*
            * Create a program for a bee farm
            * 12 oz jar - $7
            * 24 ox jar - $13
            * AskForPurchease (int ounce)
            * GetJarsCount (int ounces)
            */
        }
    }
}