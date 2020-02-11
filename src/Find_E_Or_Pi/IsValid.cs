using System;

namespace Find_E_To_The_Nth_Digit
{  
    public class IsValid
    {
        public virtual bool isValidInput(string valueEntered)
        {
            if (valueEntered == null)
            {
                return false;
            }
            else if (valueEntered.Length > 2)
            {
                return false;
            }
            else if (valueEntered.ToLower() == "q")
            {
                return true;
            }
            else if (valueEntered.ToLower() == "s")
            {
                return true;
            }
            else if (int.TryParse(valueEntered, out int n))
            {
                if (n >= 2 && n <= 14)
                { 
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}