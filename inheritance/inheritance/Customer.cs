using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Customer:Person,Interface
    {
        private int CustomerID;
        private string ShippingAddress;

        public Customer(string Address, int Age, string City, string Name, int CustomerID1, string SAddress1) :
            base(City, Age, Name, Address)
        {
            CustomerID = CustomerID1;
            ShippingAddress = SAddress1;
           
        }
        public string DoSomeWork()
        {
            string CustomerDetails;
            CustomerDetails = Address + "\r\n" + Age + "\r\n" + City + "\r\n" + Name + CustomerID + "\r\n"
                + ShippingAddress;
            return CustomerDetails;
        }
    }
}
