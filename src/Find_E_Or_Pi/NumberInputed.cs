using System;

namespace Find_E_To_The_Nth_Digit
{
    public class NumberInputed
    {
         public static void numberInputedE(string number)
         {
            int numberEntered = Int32.Parse(number);
            int displayLength = numberEntered + 2;
            Console.WriteLine($"\nYou entered the number {numberEntered}\n");
            if (numberEntered == 0 || numberEntered == 1)
            {
                Console.WriteLine("Please enter a number 2 or greater \n");
            }
            else
            {
                string eResult = Math.E.ToString().Substring(0, displayLength);
                switch (numberEntered)
                {
                    case 2:
                        Console.WriteLine($"E to the {numberEntered}nd digit is {eResult} \n");
                        break;
                    case 3:
                        Console.WriteLine($"E to the {numberEntered}rd digit is {eResult} \n");
                        break;
                    default:
                        Console.WriteLine($"E to the {numberEntered}th digit is {eResult} \n");
                        break;
                }
            }
            StartOver.startOverE();
         }

        public static void numberInputedPi(string number)
        {
            int numberEntered = Int32.Parse(number);
            int displayLength = numberEntered + 2;
            Console.WriteLine($"\nYou entered the number {numberEntered}\n");
            if (numberEntered == 0 || numberEntered == 1)
            {
                Console.WriteLine("Please enter a number 2 or greater \n");
            }
            else
            {
                string PiResult = Math.PI.ToString().Substring(0, displayLength);
                switch (numberEntered)
                {
                    case 2:
                        Console.WriteLine($"Pi to the {numberEntered}nd digit is {PiResult} \n");
                        break;
                    case 3:
                        Console.WriteLine($"Pi to the {numberEntered}rd digit is {PiResult} \n");
                        break;
                    default:
                        Console.WriteLine($"Pi to the {numberEntered}th digit is {PiResult} \n");
                        break;
                }
            }
            StartOver.startOverPi();
        }
    }
}