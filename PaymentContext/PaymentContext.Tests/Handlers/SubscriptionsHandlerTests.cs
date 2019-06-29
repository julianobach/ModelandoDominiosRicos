using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionsHandlerTests
    {

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExist()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "JONAS";
            command.LastName = "BATMAN";
            command.Document = "123456789";
            command.Email = "JONAS@BATMAN.COM";
            command.Barcode = "123456789";
            command.BoletoNumber = "123";
            command.PaymentNumber = "1234";
            command.PaidDate = DateTime.Now.AddDays(10);
            command.ExpireDate = DateTime.Now.AddDays(10);
            command.Total = 50;
            command.TotalPaid = 50;
            command.Payer = "JONAS CORP";
            command.PayerDocument = "123456789";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "JONAS@BATMAN.COM";
            command.Street = "RUA GOTHAN";
            command.Number = "555";
            command.Neighborhood = "CENTRAL PARK";
            command.City = "GOTHAN";
            command.State = "US";
            command.Country = "US";
            command.ZipCode = "12343000";

            handler.Handle(command);

            Assert.AreEqual(false, handler.Valid);
        }


    }
}
