using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpfApplication.Models
{
    public class EmployeeDetailsModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool HasFilledMBOs { get; set; }
        public DateTime DateOfJoining { get; set; }
    }    
}
