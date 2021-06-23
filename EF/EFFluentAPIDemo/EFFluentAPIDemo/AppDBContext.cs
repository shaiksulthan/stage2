using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFFluentAPIDemo
{

    class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=EmployeeSkillConnnectionString")
        {
            // Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<ClsEmployee> tblEmployees { get; set; }
        public DbSet<ClsSkill> tblSkills { get; set; }


    }

}
