using System;

namespace CustomerService
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Baran";
            customer1.LastName = "Kankuş";
            customer1.CustomerAge = 14;

            Customer customer2 = new Customer();
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.CustomerAge = 36;

            Customer[] customers = {customer1, customer2};

            foreach (var customer in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.AddNewCustomer(customer);
                customerManager.DeleteCustomer(customer);
            }
        }
    }
}
