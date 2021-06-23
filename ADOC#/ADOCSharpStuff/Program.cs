using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // API //STEP 1
using System.Data;//DATASET, TABLE , ROWS , COLUMNS

namespace ADOCSharpStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BLC9DN3\MSSQLSERVER1;Initial Catalog=CTSDATABASE;Integrated Security=SSPI;user=sa;password=abhi@123");
            SqlConnection con = new SqlConnection();//STEP 2
            con.ConnectionString = @"Data Source=DESKTOP-BLC9DN3\MSSQLSERVER1;Initial Catalog=CTSDATABASE;Integrated Security=SSPI;user=sa;password=abhi@123";
            con.Open(); // XML
            //SqlCommand com = new SqlCommand("select * from Customer", con);
            SqlCommand com = new SqlCommand(); //STEP 3
            com.CommandText = "select * from Customer";
            com.Connection = con;


            SqlDataReader dr = com.ExecuteReader();//
            Console.WriteLine("CUSTOMER DETAILS ARE AS FOLLOWS :");
            Console.WriteLine("Without while loop:");
            int counter = 1;
            Console.WriteLine(dr.HasRows);
            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine();
                Console.WriteLine("{0} Customer details :", counter);
                Console.WriteLine("CustomerID   : {0}", dr[0].ToString());
                Console.WriteLine("CustomerName : {0}", dr["CustomerName"].ToString());
                Console.WriteLine("CustomerAmount : {0}", dr["CustomerAmount"].ToString());
                Console.WriteLine("CustomerType : {0}", dr["CustomerType"].ToString());
                Console.WriteLine();
                counter++;
                dr.Read();
                Console.WriteLine();
                Console.WriteLine("{0} Customer details :", counter);
                Console.WriteLine("CustomerID   : {0}", dr[0].ToString());
                Console.WriteLine("CustomerName : {0}", dr["CustomerName"].ToString());
                Console.WriteLine("CustomerAmount : {0}", dr["CustomerAmount"].ToString());
                Console.WriteLine("CustomerType : {0}", dr["CustomerType"].ToString());
                Console.WriteLine();
                counter++;
            }
            dr.Close();
            Console.WriteLine("While loop:");
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("{0} Customer details :",counter);
                Console.WriteLine("CustomerID   : {0}",dr[0].ToString());
                Console.WriteLine("CustomerName : {0}", dr["CustomerName"].ToString());
                Console.WriteLine("CustomerAmount : {0}", dr["CustomerAmount"].ToString());
                Console.WriteLine("CustomerType : {0}", dr["CustomerType"].ToString());
                Console.WriteLine();
                counter++;

            }

            
            con.Close();

            Console.ReadLine();







        }
    }
}
