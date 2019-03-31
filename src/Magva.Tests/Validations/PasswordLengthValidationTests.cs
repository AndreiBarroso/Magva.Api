using Magva.Domain.Validations.Card;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magva.Tests.Validations
{
    [TestClass]
    public class PasswordLengthValidationTests
    {
        private PasswordLengthValidation sizeSmallerThenFour;
        private PasswordLengthValidation sizeLargeThenSix;
        private PasswordLengthValidation idealSize;

        public PasswordLengthValidationTests()
        {
            sizeSmallerThenFour = new PasswordLengthValidation("123");
            sizeLargeThenSix = new PasswordLengthValidation("1234567");
            idealSize = new PasswordLengthValidation("12345");
        }

        [TestMethod]
        public void ShouldReturnTrueWhenPasswordIsGreatethanSix()
        {
            Assert.AreEqual(true, sizeLargeThenSix.Valid);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenPasswordIsSmallerthanFour()
        {
            Assert.AreEqual(true, sizeSmallerThenFour.Valid);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenPasswordIsIdealSize()
        {
            Assert.AreEqual(false, idealSize.Valid);
        }
    }
}
