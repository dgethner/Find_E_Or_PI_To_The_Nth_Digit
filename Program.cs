using System;

namespace Find_E_To_The_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            choose();

            static void choose()
            {
                Console.WriteLine("Type e or pi to find the Nth digit of either\nAfter you find the Nth digit of either E or Pi, enter 's' to switch to the other\nEnter 'q' to quit the program\n");
                string eOrPi = Console.ReadLine();

                if (eOrPi.ToLower() == "e")
                {
                    startOverE();
                }
                else if (eOrPi.ToLower() == "pi")
                {
                    startOverPi();
                }
                else if (eOrPi.ToLower() == "q")
                {
                    Console.WriteLine("\nYou have quit the program");
                }
                else
                {
                    Console.WriteLine("\nInvalid input, please enter either e or pi\n");
                    choose();
                }
            }

            static bool isValidInput(string number)
            {
                if (number == null)
                {
                    return false;
                }
                else if (number.Length > 1)
                {
                    return false;
                }
                else if (number == "q")
                {
                    return true;
                }
                else if (number == "s")
                {
                    return true;
                }
                else if (int.TryParse(number, out int n))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static void startOverE()
            {
                Console.WriteLine("\nEnter a number and this program will generate E up to that many decimal places\nEnter 's' to switch to finding the Nth digit of Pi\nEnter 'q' to quit the program\n");
                string number = Console.ReadLine();
                if (!isValidInput(number))
                {
                    Console.WriteLine("\nInput is invalid, please enter a postive number up to 9.\n");
                    startOverE();
                }
                else if (number == "s")
                {
                    startOverPi();
                }
                else if (number != "q")
                {
                    try
                    {
                        numberInputedE(number);
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

            static void numberInputedE(string number)
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
                startOverE();
            }

            static void startOverPi()
            {
                Console.WriteLine("\nEnter a number and this program will generate Pi up to that many decimal places\nEnter 's' to switch to finding the Nth digit of E\nEnter 'q' to quit the program\n");
                string number = Console.ReadLine();
                if (!isValidInput(number))
                {
                    Console.WriteLine("\nInput is invalid, please enter a postive number up to 9.\n");
                    startOverPi();
                }
                else if (number == "s")
                {
                    startOverE();
                }
                else if (number != "q")
                {
                    try
                    {
                        numberInputedPi(number);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Exception caught");
                        startOverPi();
                    }
                }
                else
                {
                    Console.WriteLine("\nYou have quit the program");
                }
            }

            static void numberInputedPi(string number)
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
                startOverPi();
            }
        }
    }
}
