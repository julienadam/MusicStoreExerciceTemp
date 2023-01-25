using MusicStore.Entities;

namespace MusicStore.Domain
{
    public interface ICustomerRepository
    {
        int CreateCustomer(Customer customer);

        IEnumerable<Customer> GetAllCustomers();
    }

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
    }
}
