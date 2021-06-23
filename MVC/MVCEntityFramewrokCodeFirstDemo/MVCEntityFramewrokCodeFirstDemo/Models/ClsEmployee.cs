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
    //POCO : PLAIN OLD CLR OBJECT
   public class ClsEmployee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please Enter First Name e.g. John")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Last Name e.g. Doe")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Password should not be blank")]
        public string Password { get; set; }
        [DisplayName("Cell Number")]
        [Required(ErrorMessage = "Cell Number should not be blank")]
        public string CellNumber { get; set; }
        [Required(ErrorMessage = "Enter valid email address")]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<ClsSkill> ClsSkills { get; set; }

    }
}