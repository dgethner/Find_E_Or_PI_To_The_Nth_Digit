using System;

namespace Find_E_To_The_Nth_Digit
{
    public class ChooseEOrPi
    {
        public void getUserInput()
        {
            StartOver over = new StartOver();
            string firstPrompt = "Type 'e' or 'pi' to find the Nth digit of either\nAfter you find the Nth digit of either E or Pi, enter 's' to switch to the other\nEnter 'q' to quit the program\n";
            Console.WriteLine(firstPrompt);
            string eOrPi = Console.ReadLine();
            choose(eOrPi, over);
        }

        public string displayString(string userInput)
        {
            string message;
            switch (userInput)
            {
                case "q":
                    message = "\nYou have quit the program";
                    break;
                default:
                    message = "\nInvalid input, please enter either 'e' or 'pi'\n";
                    break;
            }
            return message;
        }

        public void choose(string userInput, StartOver over)
        {
            string message = displayString(userInput);
            switch (userInput.ToLower())
            {
                case "e":
                    over.startOverE();
                    break;
                case "pi":
                    over.startOverPi();
                    break;
                case "q":
                    Console.WriteLine(message);
                    break;
                default:
                    if (message.Contains("Invalid"))
                        Console.WriteLine(message);
                    getUserInput();
                    break;
            }
        }
    }
}