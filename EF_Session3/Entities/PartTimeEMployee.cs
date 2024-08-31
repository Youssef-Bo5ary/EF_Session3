using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session3.Entities
{
    internal class PartTimeEmployee : Employee
    {
       
        public int CountHours { get; set; }
        public decimal HourRate { get; set; }

    }
}
