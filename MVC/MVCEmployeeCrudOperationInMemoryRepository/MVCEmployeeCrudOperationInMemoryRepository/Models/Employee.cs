using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmployeeCrudOperationInMemoryRepository.Models
{
    public class Employee
    {
        public int EMPID { get; set; }
        public string EMPNAME { get; set; }
        public DateTime DOJ { get; set; }
        public string DEPTNAME { get; set; }
        public string DEPTLOCATION { get; set; }

    }
}