using MusicStore.Entities;

namespace MusicStore.Domain
{
    public class DbCustomerRepository : ICustomerRepository
    {
        private readonly ChinookContext context;

        public DbCustomerRepository(ChinookContext context)
        {
            this.context = context;
        }

        public int CreateCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer.CustomerId;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customers.ToList();
        }

        public bool IsEmailTaken(string email)
        {
            return context.Customers.Any(c => c.Email == email);
        }
    }
}
