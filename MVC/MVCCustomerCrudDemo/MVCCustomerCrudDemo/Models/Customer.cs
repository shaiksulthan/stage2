using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomerCrudDemo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }

    }
}