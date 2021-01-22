namespace CustomerService
{
    public class CustomerManager
    {
        public void AddNewCustomer(Customer customer)
        {
            System.Console.WriteLine("-----------------------------------------------------------------------");
            System.Console.WriteLine("Aramıza hoşgeldin " + customer.FirstName + " " + customer.LastName + "!");
            System.Console.WriteLine("-----------------------------------------------------------------------");
        }
        public void DeleteCustomer(Customer customer)
        {
            System.Console.WriteLine("-----------------------------------------------------------------------");
            System.Console.WriteLine("Aramızdan ayrıldığına üzüldük " + customer.FirstName + " " + customer.LastName + " :(");
            System.Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}