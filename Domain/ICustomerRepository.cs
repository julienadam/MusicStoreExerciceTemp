using MusicStore.Entities;

namespace MusicStore.Domain
{
    public interface ICustomerRepository
    {
        int CreateCustomer(Customer customer);

        IEnumerable<Customer> GetAllCustomers();
        bool IsEmailTaken(string email);
    }
}
