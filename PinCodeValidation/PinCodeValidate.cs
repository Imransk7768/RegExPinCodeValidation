using System.Text.RegularExpressions;

namespace PinCodeValidation
{
    public class PinCodeValidate
    {
        public const string PATTERN = "^[0-9]{6}$";
        public const string FirstLetter = "^[A-Za-z]{1}[0-9]{6}$";
        public const string LastLetter = "^[0-9]{6}[A-Za-z]{1}$";
        public string ValidatePinCode(string pincode)
        {
            if (Regex.IsMatch(pincode, PATTERN))
            {
                Console.WriteLine("Pincode Matches");
            }
            else
            {
                Console.WriteLine("Verify Pincode Again");
            }
            return pincode;
        }
        public string PinCode_FirstLetter(string pincode)
        {
            if (Regex.IsMatch(pincode, FirstLetter))
            {
                Console.WriteLine("Pincode Matches");
            }
            else
            {
                Console.WriteLine("Verify Pincode Again");
            }
            return pincode;
        }
        public string PinCode_LastLetter(string pincode)
        {
            if (Regex.IsMatch(pincode, LastLetter))
            {
                Console.WriteLine("Pincode Matches");
            }
            else
            {
                Console.WriteLine("Verify Pincode Again");
            }
            return pincode;
        }
    }
}