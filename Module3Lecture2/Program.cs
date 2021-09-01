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

        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        static double GetTaxRate(string state)
        {
            double tax;
            if (state.Equals("WI"))
            {
                return .05;
            } else if (state.Equals("MN"))
            {
                return .0634;
            }
            else
            {
                return 0;
            }
        }
        
        /*
         * method that returns the above AskForPurchase, GetJarsCount methods

         */
        static void HoneyJarApp()
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

        /*
         * Generate number between 1 - 10
         */
        static int GenerateNumber()
        {
            return new Random().Next(1, 11);
        }

        /*
         * Method that takes user number and checks if between 1 - 10
         * If <= 10 -> check value against random number generated in
         * GenerateNumber() method.
         * If > 10  -> value is invalid, prompt users and recursively call function
         */
        static void ClairvoyanceTest(int randNum)
        {
            int actual = GenerateNumber();
            if (randNum <= 10)
            {
                if (randNum == actual)
                {
                    Console.WriteLine($"Guess: {randNum}  Actual: {actual}  -  You ARE clairvoyant!");
                }
                else
                {
                    Console.WriteLine($"Guess: {randNum}  Actual: {actual}  -  You ARE NOT NOT! clairvoyant!");
                }
            }
            else
            {
                Console.WriteLine("Input number between 1 & 10");
                ClairvoyanceTest(Convert.ToInt32(Console.ReadLine()));
            }
        }
        
        static void Main(string[] args)
        {
            //HoneyJarApp();
            // double tax = GetTaxRate("WI");
            // Console.WriteLine(tax);

            Console.WriteLine("Input number>");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            ClairvoyanceTest(inputNum);
        }
    }
}