using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepositoryPatternDemo
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        AppDBContext context;
        public SQLEmployeeRepository( )
        {
           context = new  AppDBContext();

        }
        public ClsEmployee Add(ClsEmployee employee)
        {
            context.tblEmployees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public void AddSkill(ClsSkill skill)
        {
            context.tblSkills.Add(skill);
            context.SaveChanges();

        }

        public ClsEmployee Delete(int id)
        {
            ClsEmployee employee = context.tblEmployees.Find(id);
            if (employee != null)
            {
                context.tblEmployees.Remove(employee);
                context.SaveChanges();

            }
            return employee;

        }

        public void DeleteSkill(int id)
        {
            ClsSkill skill = context.tblSkills.Find(id);
            if (skill != null)
            {
                context.tblSkills.Remove(skill);
                context.SaveChanges();
            }
        }

        public IEnumerable<ClsEmployee> GetAllEmployee()
        {
            return context.tblEmployees;
        }

        public IEnumerable<ClsSkill> GetAllSkill(int Id)
        {
            return context.tblSkills.Where(s => s.EmployeeID == Id).ToList<ClsSkill>();


        }

        public ClsEmployee GetEmployee(ClsEmployee employee)
        {
            return context.tblEmployees.FirstOrDefault(e => e.Email == employee.Email && e.Password == employee.Password);

        }

        public ClsEmployee GetEmployeeByID(int id)
        {

            return context.tblEmployees.FirstOrDefault(e => e.EmpID == id);
        }

        public ClsSkill GetSkill(int Id)
        {
            return context.tblSkills.FirstOrDefault(s => s.SkillId == Id);
        }

        public ClsEmployee Update(ClsEmployee employeeChanges)
        {
            ClsEmployee employee = context.tblEmployees.FirstOrDefault(e => e.EmpID == employeeChanges.EmpID);
            if (employee != null)
            {
                employee.FirstName = employeeChanges.FirstName;
                employee.LastName = employeeChanges.LastName;
                employee.Password = employeeChanges.Password;
                employee.CellNumber = employeeChanges.CellNumber;
                employee.Email = employeeChanges.Email;

            }
            var emp = context.tblEmployees.Attach(employee);
           
            context.SaveChanges();

            return employee;


        }
    }
}
