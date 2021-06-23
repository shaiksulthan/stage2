using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCSharpStuff
{
    class DBMLDEMO
    {
        static void Main(string[] args)
        {
            CUSTOMERADODBML Customerdbml = new CUSTOMERADODBML();
            Customerdbml.ShowCustomerDetails();

            Customer cust = new Customer()
            {
                CustomerID = 1003,
                CustomerName = "Mahantesh",
                CustomerAmount = 1500,
                CustomerType = "GOLD"


            };

            Customerdbml.AddRecord(cust);
            Console.ReadLine();
            Console.WriteLine("After Insert Customer details are as follows  :");

            Customerdbml.ShowCustomerDetails();
            Console.ReadLine();


        }

    }
}
