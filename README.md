# Module3Lecture2 #
Code written during 9/1/2021 class that covers methods, loops, more string interpolation

## Notable ##
--number subtracts number variable before any more code is evaluated

number = 10;
WriteLine(--number) -> prints 9
WriteLine(number++) -> prints 10

WriteLine($("Best string interpolation for {number}"))

Int32.TryParse(Console.ReadLine(), out age);  ->  This is the best way as it builds in validation. ADVANCED