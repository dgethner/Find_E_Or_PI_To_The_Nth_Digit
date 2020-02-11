using System;

namespace Find_E_To_The_Nth_Digit
{
    public class StartOver
    {
        public StartOver(){}

        public virtual void startOverE()
        {
            NumberInputed ni = new NumberInputed();
            IsValid isValid = new IsValid();

            Console.WriteLine("\nEnter a positive number up to '14' and this program will generate E up to that many decimal places\nEnter 's' to switch to finding the Nth digit of Pi\nEnter 'q' to quit the program\n");
            string number = userInputMethod();
            number.ToLower();
            if (!isValid.isValidInput(number))
            {
                Console.WriteLine("\nInput is invalid, please enter a postive number up to '14'.\n");
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
                    ni.numberInputedE(number);
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

        public virtual string userInputMethod()
        {
            string number = Console.ReadLine();
            return number;
        }

        public virtual void startOverPi()
        {
            
            NumberInputed ni = new NumberInputed();
            IsValid isValid = new IsValid();

            Console.WriteLine("\nEnter a positive number up to '14' and this program will generate Pi up to that many decimal places\nEnter 's' to switch to finding the Nth digit of E\nEnter 'q' to quit the program\n");
            string number = userInputMethod();
            if (!isValid.isValidInput(number))
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
                    ni.numberInputedPi(number);
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