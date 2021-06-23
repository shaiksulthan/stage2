using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOCSharpStuff
{

    class ClsProcedureCall
    {
        SqlConnection con;
        SqlCommand com;
        public ClsProcedureCall()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-BLC9DN3\MSSQLSERVER1;Initial Catalog=CTSDATABASE;Integrated Security=SSPI;user=sa;password=abhi@123";
            con.Open();
        }
        #region CALLING PARAMETERIZED STORED PROCEDURE
        public void CallParaProcedure()
        {
            ClsEmployee Emp = new ClsEmployee()
            {
                EMPNAME="VIKAS",
                EMPDESG="PAT",
                DEPTID=101,
                SALARY=12345
            };
            com = new SqlCommand();
            com.CommandText = "spAddEmployee";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = con;
            com.Parameters.Add("@EMPNAME", SqlDbType.VarChar).Value = Emp.EMPNAME;
            com.Parameters.Add("@EMPDESG", SqlDbType.VarChar).Value = Emp.EMPDESG;
            com.Parameters.Add("@DEPTID", SqlDbType.Int).Value = Emp.DEPTID;
            com.Parameters.Add("@SALARY", SqlDbType.Int).Value = Emp.SALARY;
            int i = com.ExecuteNonQuery();
            Console.WriteLine("{0}. record inserted :", i);
        }
        #endregion
        #region CALLING NON PARAMETERIZED STORED PROCEDURE
        public void CallNonParaProcedure()
        {
            com = new SqlCommand();
            com.CommandText = "spshowemployeedetails";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            int count = 1;
            Console.WriteLine("Employees details are as follows :");
            while (dr.Read())
            {
                Console.WriteLine("{0}. Employee details :", count);
                Console.WriteLine("Employee ID        : {0}", dr["EMPID"].ToString());
                Console.WriteLine("Employee Name      : {0}", dr["EMPNAME"].ToString());
                Console.WriteLine("Employee Desg      : {0}", dr["EMPDESG"].ToString());
                Console.WriteLine("Employee DeptID    : {0}", dr["DEPTID"].ToString());
                Console.WriteLine("Employee Dept Name : {0}", dr["DEPTNAME"].ToString());
                Console.WriteLine("Employee Dept Loc  : {0}", dr["DEPTLOC"].ToString());
                


                count++;
                Console.WriteLine();

            }
            dr.Close();



        }
        #endregion
        #region CALLING PARAMETERIZED STORED PROCEDURE WITH OUT TYPE PARAMETER
        public void CallParaProcedureWithOutpara()
        {
            ClsEmployee Emp = new ClsEmployee()
            {
                EMPID=1010,
                EMPNAME="VIKAS"

            };
            com = new SqlCommand();
            com.CommandText = "spouttypeselectEmployee";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = con;
            com.Parameters.Add("@EMPID", SqlDbType.Int).Value = Emp.EMPID;
            com.Parameters.Add("@EMPNAME", SqlDbType.VarChar).Value = Emp.EMPNAME;
            SqlParameter OutP =
                new SqlParameter("@CurrentDateTime",SqlDbType.DateTime);
            OutP.Direction = ParameterDirection.Output;
            com.Parameters.Add(OutP);
            int i = com.ExecuteNonQuery();
            Console.WriteLine("{0} {1} record inserted ", OutP.Value, i);
            com.Dispose();
        }
        #endregion


    }
    class CallStoredProcedureDemo
    {
        static void Main(string[] args)
        {

            ClsProcedureCall clsProcedureCall = new ClsProcedureCall();
            //clsProcedureCall.CallNonParaProcedure();
            //Console.ReadLine();
            //clsProcedureCall.CallParaProcedure();
            //Console.ReadLine();
            clsProcedureCall.CallParaProcedureWithOutpara();
            
            

        }

    }
}
