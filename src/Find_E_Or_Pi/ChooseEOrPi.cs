using System;

namespace Find_E_To_The_Nth_Digit
{
    public class ChooseEOrPi
    {
        public static void choose()
        {
            Console.WriteLine("Type 'e' or 'pi' to find the Nth digit of either\nAfter you find the Nth digit of either E or Pi, enter 's' to switch to the other\nEnter 'q' to quit the program\n");
            string eOrPi = Console.ReadLine();

            if (eOrPi.ToLower() == "e")
            {
                StartOver.startOverE();
            }
            else if (eOrPi.ToLower() == "pi")
            {
                StartOver.startOverPi();
            }
            else if (eOrPi.ToLower() == "q")
            {
                Console.WriteLine("\nYou have quit the program");
            }
            else
            {
                Console.WriteLine("\nInvalid input, please enter either 'e' or 'pi'\n");
                choose();
            }
        }
    }
}