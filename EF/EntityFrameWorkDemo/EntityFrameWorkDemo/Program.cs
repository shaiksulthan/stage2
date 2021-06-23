using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RETRIVE DATA FROM CUSTOMER TABLE

            CTSDATABASEEntities objContext = new CTSDATABASEEntities();

            List<Customer> objCustomers = objContext.Customers.ToList<Customer>();
            foreach (Customer cust in objCustomers)
            {

                Console.WriteLine(cust.CustomerID+" "+cust.CustomerName+" "+cust.CustomerAmount+" "+cust.CustomerType);

            }

            #endregion
            #region INSERT RECORD
            //Customer obj = new Customer()
            //{
            //    CustomerID = 1007,
            //    CustomerName = "Deepthi",
            //    CustomerAmount = 12345,
            //    CustomerType = "SILVER"

            //};


            //objContext.Customers.Add(obj);
            //objContext.SaveChanges();
            #endregion

            #region RECORD UPDATE

            Customer customer = objContext.Customers.FirstOrDefault(c=>c.CustomerID==1005);
            Console.WriteLine(customer.CustomerID);
            customer.CustomerName = "Vikas Kumar Thakur";

            objContext.SaveChanges();


            #endregion

            #region DELETE RECORD

            Customer customer1 = objContext.Customers.FirstOrDefault(c => c.CustomerID == 1002);
            objContext.Customers.Remove(customer1);
            objContext.SaveChanges();
            #endregion


        }
    }
}
