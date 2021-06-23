using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExceptionHandlingDemo.Models
{
    public class ClsEmployee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public void Show()
        {
            Console.WriteLine("Hello Employees:");

        }

    }
}