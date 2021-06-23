using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ADOCSharpStuff
{
    //CRUD : 
    class CUSTOMERADODBML
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;


        public CUSTOMERADODBML()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-BLC9DN3\MSSQLSERVER1;Initial Catalog=CTSDATABASE;Integrated Security=SSPI;user=sa;password=abhi@123";
            con.Open(); // XML
        }

        public void AddRecord(Customer Cust)
        {
            com = new SqlCommand("insert into Customer values ("+Cust.CustomerID+",@CustomerName,@CustomerAmount,@CustomerType)", con);
            com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = Cust.CustomerID;//:CustomerID
            com.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = Cust.CustomerName;
            com.Parameters.Add("@CustomerAmount", SqlDbType.Int).Value = Cust.CustomerAmount;
            com.Parameters.Add("@CustomerType", SqlDbType.VarChar).Value = Cust.CustomerType;
            int i = com.ExecuteNonQuery();
            Console.WriteLine("{0} Record inserted :",i);
                  

        }



            public void ShowCustomerDetails()
        {
            com = new SqlCommand();
            com.CommandText = "select * from Customer";
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            Console.WriteLine("CUSTOMER DETAILS ARE AS FOLLOWS :");

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
            dr.Close();
        }


       

    }
}
