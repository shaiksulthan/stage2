using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EFRepositoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;
            do
            {
                Console.WriteLine("-------------MENU-----------------");
                Console.WriteLine("1. FOR SQLSERVER REPOSITORY :");
                Console.WriteLine("2. FOR INMEMORY REPOSITORY :");
                Console.WriteLine("3. EIXT");
                Console.Write("ENTER YOU CHOICE : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("DATA FROM SQL SERVER REPOSITORY :");
                        SQLEmployeeRepository sQLEmployeeRepository = new SQLEmployeeRepository();
                        IEnumerable<ClsEmployee> clsEmployees = sQLEmployeeRepository.GetAllEmployee();
                        foreach (ClsEmployee emp in clsEmployees)
                        {
                            Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Email);
                        }
                        break;
                    case 2:
                        Console.WriteLine("DATA FROM INMEMORY REPOSITORY :");
                        InMemoryRepository inMemoryRepository = new InMemoryRepository();
                        clsEmployees = inMemoryRepository.GetAllEmployee();
                        foreach (ClsEmployee emp in clsEmployees)
                        {
                            Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Email);
                        }
                        break;
                    case 3:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("INVALID CHOICE:");
                        break;
                }
                Console.Write("Do you want to continue  [y/n] :" );
                ch = Convert.ToChar(Console.ReadLine());


            } while (ch=='y'||ch=='Y');


           




        }
    }
}
