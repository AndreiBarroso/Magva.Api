using Magva.Domain.Shared.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magva.Tests.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        private Email validEmail;
        private Email inValidEmail;

        public EmailTests()
        {
            validEmail = new Email("m.son@gmail.com.br");
            inValidEmail = new Email("_ascord2.sf.asdf.fas");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenEmailIsNotValid()
        {
            Assert.AreEqual(false, inValidEmail.Valid);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenEmailIsNotValid()
        {
            Assert.AreEqual(true, validEmail.Valid);
        }
    }
}
