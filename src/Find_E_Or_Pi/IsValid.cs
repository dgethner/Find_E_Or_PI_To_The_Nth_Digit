using System;

namespace Find_E_To_The_Nth_Digit
{  
    public class IsValid
    {
        public static bool isValidInput(string number)
        {
            if (number == null)
            {
                return false;
            }
            else if (number.Length > 2)
            {
                return false;
            }
            else if (number.ToLower() == "q")
            {
                return true;
            }
            else if (number.ToLower() == "s")
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
    }
}