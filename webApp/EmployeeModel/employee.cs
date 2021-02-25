using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace EmployeeModel
{

    public class employee
    {

        public int id { get; set; }
        [Required(ErrorMessage = "Email is not valid")]
        [EmailAddress]
      
        public string Email { get; set; }
        [Required (ErrorMessage="Name can't be empty")]

        public string FullName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }

   
}
