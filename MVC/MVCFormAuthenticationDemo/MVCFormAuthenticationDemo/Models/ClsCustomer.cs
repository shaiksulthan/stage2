using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormAuthenticationDemo.Models
{
    public class ClsCustomer
    {
        public int CustCode { get; set; }
        public string CustName { get; set; }
        public double Amount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}