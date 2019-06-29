using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    //Repository Pattern
    public interface IStudentRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);

    }
}