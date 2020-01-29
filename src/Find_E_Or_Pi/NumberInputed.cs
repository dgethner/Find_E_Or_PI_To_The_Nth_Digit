using System;

namespace Find_E_To_The_Nth_Digit
{
    public class NumberInputed
    {
         public static void numberInputedE(string number)
         {
            int numberEntered = Int32.Parse(number);
            int displayLength = numberEntered + 2;
            Console.WriteLine($"\nYou entered the number '{numberEntered}'\n");
            if (numberEntered < 2)
            {
                Console.WriteLine("Please enter a positive number '2' or greater. \n");
            }
            else if (numberEntered > 14)
            {
                Console.WriteLine("Please enter a positive number '14' or lower. \n");
            }
            else
            {
                double eResult = Math.E;
                string eConverted = eResult.ToString().Substring(0, displayLength);
                switch (numberEntered)
                {
                    case 2:
                        Console.WriteLine($"E to the {numberEntered}nd digit is {eConverted} \n");
                        break;
                    case 3:
                        Console.WriteLine($"E to the {numberEntered}rd digit is {eConverted} \n");
                        break;
                    default:
                        Console.WriteLine($"E to the {numberEntered}th digit is {eConverted} \n");
                        break;
                }
            }
            StartOver.startOverE();
         }

        public static void numberInputedPi(string number)
        {
            int numberEntered = Int32.Parse(number);
            int displayLength = numberEntered + 2;
            Console.WriteLine($"\nYou entered the number '{numberEntered}'\n");
            if (numberEntered < 2)
            {
                Console.WriteLine("Please enter a number '2' or greater. \n");
            }
            else if (numberEntered > 14)
            {
                Console.WriteLine("Please enter a positive number '14' or lower. \n");
            }
            else
            {
                double PiResult = Math.PI;
                string PiConverted = PiResult.ToString().Substring(0, displayLength);
                switch (numberEntered)
                {
                    case 2:
                        Console.WriteLine($"Pi to the {numberEntered}nd digit is {PiConverted} \n");
                        break;
                    case 3:
                        Console.WriteLine($"Pi to the {numberEntered}rd digit is {PiConverted} \n");
                        break;
                    default:
                        Console.WriteLine($"Pi to the {numberEntered}th digit is {PiConverted} \n");
                        break;
                }
            }
            StartOver.startOverPi();
        }
    }
}