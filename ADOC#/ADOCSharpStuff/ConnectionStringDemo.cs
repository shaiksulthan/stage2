using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOCSharpStuff
{
    class ConnectionStringDemo
    {
        static void Main(string[] args)
        {
            string mycon = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            Console.WriteLine(mycon);

            SqlConnection con = new SqlConnection();//STEP 2
            con.ConnectionString = mycon;
            con.Open(); // XML
            //SqlCommand com = new SqlCommand("select * from Customer", con);
            SqlCommand com = new SqlCommand(); //STEP 3
            com.CommandText = "select * from Customer";
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            int counter = 1;
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("{0} Customer details :", counter);
                Console.WriteLine("CustomerID   : {0}", dr[0].ToString());
                Console.WriteLine("CustomerName : {0}", dr["CustomerName"].ToString());
                Console.WriteLine("CustomerAmount : {0}", dr["CustomerAmount"].ToString());
                Console.WriteLine("CustomerType : {0}", dr["CustomerType"].ToString());
                Console.WriteLine();
                counter++;

            }



        }
    }
}
