using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);      
        }

        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()
        {
            var doc = new Document("93946690000157", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);      
        }

         [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
           var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);        
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("72079135082")]
        [DataRow("87884189011")]
        [DataRow("77606362025")]
        public void ShouldReturnSucessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);    
        }
    }
}
