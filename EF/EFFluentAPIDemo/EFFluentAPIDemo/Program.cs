using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EFFluentAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDBContext db = new AppDBContext();
            db.tblEmployees.ToList<ClsEmployee>().ForEach(e =>
            Console.WriteLine(e.EmpID+" "+e.FirstName + " " + e.LastName + " " + e.CellNumber)
            
            );

            ClsEmployee emp = db.tblEmployees.FirstOrDefault(e => e.EmpID == 4);


            db.tblEmployees.Remove(emp);
            db.SaveChanges();
            List<ClsEmployee> EmployeeList = db.tblEmployees.ToList<ClsEmployee>();
            var SomeList = db.tblEmployees.Select(e => e);


            foreach (var item in SomeList)
            {
                Console.WriteLine(item.Email);
            }
            //SqlConnection con = new SqlConnection();
            //con.Open();
            //SqlCommand com = new SqlCommand("select * from tblEmployee", con);
            //DataTable table = new DataTable();
            //table.Load(com.ExecuteReader());
            



           
           
          

        }
    }
}
