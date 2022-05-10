using NUnit.Framework;
using PinCodeValidation;

namespace PinCodeTestUnit
{
    public class TestUnit
    {
        [Test]
        public void PincodeTest1()
        {
            PinCodeValidate validate = new PinCodeValidate();
            string actual = validate.ValidatePinCode("400088");
            Assert.AreEqual(actual, "400088");
        }
    }
}