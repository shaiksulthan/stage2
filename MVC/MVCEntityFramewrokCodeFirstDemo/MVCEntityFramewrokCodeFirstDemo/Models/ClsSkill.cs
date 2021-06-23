using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEntityFramewrokCodeFirstDemo.Models
{
   public class ClsSkill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkillId { get; set; }
        [ForeignKey("ClsEmployee")]
        public int EmployeeID { get; set; }
        [DisplayName("Skill Name")]
        [Required(ErrorMessage = "Skill name should not be blank")]
        public string SkillName { get; set; }
        [Required(ErrorMessage = "Employee Role should not be blank")]
        [DisplayName("Role")]
        public string Role { get; set; }
        [DisplayName("Experience In Years")]
        [Required(ErrorMessage = "Experience in years should not be blank")]
        public int ExperienceInYears { get; set; }
        public virtual ClsEmployee ClsEmployee { get; set; }
    }
}