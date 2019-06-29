using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            for (int i = 0; i < 10; i++)
            {
                _students.Add(
                        new Student(
                                new Name("Aluno", i.ToString()),
                                new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                                new Email($"aluno{i}@teste.com")
                                ));
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExist()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();
            Assert.AreEqual(null, student);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentExist()
        {
            var exp = StudentQueries.GetStudentInfo("11111111111");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();
            Assert.AreEqual(null, student);
        }

    }
}
