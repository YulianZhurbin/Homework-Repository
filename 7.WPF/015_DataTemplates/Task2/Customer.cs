using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Task2
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

        public static ObservableCollection<Customer> GetCustomerList()
        {
            ObservableCollection<Customer> collection = new ObservableCollection<Customer>();
            collection.Add(new Customer() { FirstName = "Donald", LastName = "Smith", Age = "25", City = "New Jersey" });
            return collection;
        }
    }
}
