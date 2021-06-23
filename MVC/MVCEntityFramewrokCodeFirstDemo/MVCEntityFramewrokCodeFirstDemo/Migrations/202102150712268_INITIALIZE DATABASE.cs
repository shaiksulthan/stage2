namespace MVCEntityFramewrokCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INITIALIZEDATABASE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClsEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CellNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID);
            
            CreateTable(
                "dbo.ClsSkills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        SkillName = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        ExperienceInYears = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.ClsEmployees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClsSkills", "EmployeeID", "dbo.ClsEmployees");
            DropIndex("dbo.ClsSkills", new[] { "EmployeeID" });
            DropTable("dbo.ClsSkills");
            DropTable("dbo.ClsEmployees");
        }
    }
}
