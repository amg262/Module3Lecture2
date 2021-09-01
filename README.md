# Module3Lecture2 #
Code written during 9/1/2021 class that covers methods, loops, more string interpolation

## Notable ##
--number subtracts number variable before any more code is evaluated

number = 10;
WriteLine(--number) -> prints 9
WriteLine(number++) -> prints 10

WriteLine($("Best string interpolation for {number}"))

Int32.TryParse(Console.ReadLine(), out age);  ->  This is the best way as it builds in validation. ADVANCED


### Do While loop using TryParse input validation ###
do
    {
        // Need Pausing -> ReadKey(); which waits for 1 keystroke
        // This clears console
        Console.Clear();
        
        Console.WriteLine("1. Option One 2. Option Two 3. Exit\n");
        //option = Convert.ToInt32(Console.ReadLine());

        // Again - using advanced, better way of TryParse
        Int32.TryParse(Console.ReadLine(), out option);

        switch (option)
        {
            case 1:
                Console.WriteLine("1 + 2 = 3");
                break;
            case 2:
                Console.WriteLine("3 - 2 = 1");
                break;
            case 3:
                Console.WriteLine("Bye!");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }

        // Pauses for key to be entered
        Console.ReadKey();
        
    } while (option != 3);


    Console.WriteLine(age);