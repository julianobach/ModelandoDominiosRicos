using PaymentContext.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        // more info in course mwa-api balta.io
        public static Expression<Func<Student,bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number == document;
        }
    }
}