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
        [Test]
        public void PincodeTest2()
        {
            PinCodeValidate validate = new PinCodeValidate();
            string actual = validate.PinCode_FirstLetter("A400088");
            Assert.AreEqual(actual, "A400088");
        }
        [Test]
        public void PincodeTest3()
        {
            PinCodeValidate validate = new PinCodeValidate();
            string actual = validate.PinCode_LastLetter("400088A");
            Assert.AreEqual(actual, "400088A");
        }
    }
}