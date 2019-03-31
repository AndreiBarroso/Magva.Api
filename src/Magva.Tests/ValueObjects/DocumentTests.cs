using Magva.Domain.Shared.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magva.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        private Document valueDocument;
        private Document invalidDocument;

        public DocumentTests()
        {
            valueDocument = new Document("35278933003");
            invalidDocument = new Document("12345678910");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenDocumentIsNotValid()
        {
            Assert.AreEqual(false, invalidDocument.Valid);

        }

        [TestMethod]
        public void ShouldReturnTrueWhenDocumentIsValid()
        {
            Assert.AreEqual(true, valueDocument.Valid);
        }
    }
}
