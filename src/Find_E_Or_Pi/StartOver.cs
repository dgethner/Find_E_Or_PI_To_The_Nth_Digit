using System;

namespace Find_E_To_The_Nth_Digit
{
    public class StartOver
    {
        public static void startOverE()
        {
            Console.WriteLine("\nEnter a positive number up to '14' and this program will generate E up to that many decimal places\nEnter 's' to switch to finding the Nth digit of Pi\nEnter 'q' to quit the program\n");
            string number = Console.ReadLine();
            if (!IsValid.isValidInput(number))
            {
                Console.WriteLine("\nInput is invalid, please enter a postive number up to '14'.\n");
                startOverE();
            }
            else if (number.ToLower() == "s")
            {
                startOverPi();
            }
            else if (number.ToLower() != "q")
            {
                try
                {
                    NumberInputed.numberInputedE(number);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Exception caught");
                    startOverE();
                }
            }
            else
            {
                Console.WriteLine("\nYou have quit the program");
            }
        }

        public static void startOverPi()
        {
            Console.WriteLine("\nEnter a positive number up to '14' and this program will generate Pi up to that many decimal places\nEnter 's' to switch to finding the Nth digit of E\nEnter 'q' to quit the program\n");
            string number = Console.ReadLine();
            if (!IsValid.isValidInput(number))
            {
                Console.WriteLine("\nInput is invalid, please enter a postive number up to '14'.\n");
                startOverPi();
            }
            else if (number.ToLower() == "s")
            {
                startOverE();
            }
            else if (number.ToLower() != "q")
            {
                try
                {
                    NumberInputed.numberInputedPi(number);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Exception caught, please enter a positive number up to '14'");
                    startOverPi();
                }
            }
            else
            {
                Console.WriteLine("\nYou have quit the program");
            }
        }
    }
}