using System.Text.RegularExpressions;

namespace PinCodeValidation
{
    public class PinCodeValidate
    {
        public const string PATTERN = "^[0-9]{6}$";
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
    }
}