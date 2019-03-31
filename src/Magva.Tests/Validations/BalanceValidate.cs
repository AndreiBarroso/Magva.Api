using Magva.Domain.Validations.Customer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magva.Tests.Validations
{
    [TestClass]
    public class BalanceValidateTests
    {

        private BalanceValidate zero;
        private BalanceValidate negative;
        private BalanceValidate positive;

        public BalanceValidateTests()
        {
            zero = new BalanceValidate(0);
            negative = new BalanceValidate(-3);
            positive = new BalanceValidate(1);

        }

        [TestMethod]
        public void ShouldReturnTrueWhenBalanceIsZeroValue()
        {
            Assert.AreEqual(true, zero.Valid);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenBalanceIsNegativeValue()
        {
            Assert.AreEqual(true, negative.Valid);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenBalanceIsPositiveValue()
        {
            Assert.AreEqual(false, positive.Valid);
        }
    }
}
