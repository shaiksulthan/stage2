using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmployeeCrudOperationInMemoryRepository.Models;


namespace MVCEmployeeCrudOperationInMemoryRepository.Controllers
{
    public class EmployeeCrudController : Controller
    {

        static List<Employee> Employees = new List<Employee>()
        {
          new Employee()
          {
              EMPID=1001,
              EMPNAME="Sanchayeta",
              DOJ=new DateTime(2020,12,18),
              DEPTNAME="ADM",
              DEPTLOCATION="KOLKATA"
         }
        };
        // GET: EmployeeCrud
        public ActionResult Index()
        {
            return View(Employees);
        }
       
        [HttpGet] // Anotation / Attribute / Telling behaviour of method 
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (Employees.Count==0)
            {
                employee.EMPID = 1001;
                Employees.Add(employee);
            }
            else
            {
                int id = Employees.Max(e => e.EMPID);
                employee.EMPID = id + 1;
                Employees.Add(employee);
            }

           
            return View("Index", Employees);
        }



        [HttpGet]
        public ActionResult EditEmployee(int Id)
        {
            Employee employee = Employees.FirstOrDefault(e => e.EMPID == Id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee employee)
        {
            Employee emp = Employees.FirstOrDefault(e => e.EMPID == employee.EMPID);
            emp.EMPNAME = employee.EMPNAME;
            emp.DOJ = employee.DOJ;
            emp.DEPTNAME = employee.DEPTNAME;
            emp.DEPTLOCATION = employee.DEPTLOCATION;

            return View("Index", Employees);
        }



        [HttpGet]
        public ActionResult EmployeeDetails(int Id)
        {
            Employee employee = Employees.FirstOrDefault(e => e.EMPID == Id);
            return View(employee);
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int Id)
        {
            Employee employee = Employees.FirstOrDefault(e => e.EMPID == Id);
            Employees.Remove(employee);

            return View("Index", Employees);
        }



    }
}