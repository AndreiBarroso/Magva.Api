using Magva.Domain.Validations.Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magva.Tests.Validations
{
    [TestClass]
    public class BalanceValidateTests
    {

        private BalanceValidation zero;
        private BalanceValidation negative;
        private BalanceValidation positive;

        public BalanceValidateTests()
        {
            zero = new BalanceValidation(0);
            negative = new BalanceValidation(-3);
            positive = new BalanceValidation(1);

        }

        [TestMethod]
        public void ShouldReturnTrueWhenBalanceIsZeroValue()
        {
            Assert.AreEqual(true, zero.negative);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenBalanceIsNegativeValue()
        {
            Assert.AreEqual(true, negative.negative);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenBalanceIsPositiveValue()
        {
            Assert.AreEqual(false, positive.positive);
        }
    }
}
