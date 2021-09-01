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

            if (answer == 'y')
                count = GetJarsCount(ounces);

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

            int jars12 = 0;
            int jars24 = 0;
            double totalJars12 = 0, totalJars24 = 0, total = 0;
            jars12 = AskForPurchase(12);
            jars24 = AskForPurchase(24);
            Console.WriteLine(jars12);
            Console.WriteLine(jars24);

            if (jars12 > 0)
            {
                totalJars12 = jars12 * 7;
                total += totalJars12;
            }

            if (jars24 > 0)
            {
                totalJars24 = jars24 * 7;
                total += totalJars24;
            }

            Console.WriteLine($"For {jars12} 12oz jars the price is {totalJars12:C}");
            Console.WriteLine($"For {jars24} 24oz jars the price is {totalJars24:C}");
            Console.WriteLine($"Total cost: {total:C}");
        }
    }
}