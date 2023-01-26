using MusicStore.Entities;

namespace MusicStore.Domain
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        List<Customer> customers = new List<Customer>();

        public int CreateCustomer(Customer customer)
        {
            customers.Add(customer);
            return 0;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public bool IsEmailTaken(string email)
        {
            return customers.Any(c => c.Email == email);
        }
    }
}
