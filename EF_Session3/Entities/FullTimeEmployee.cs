using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session3.Entities
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary {  get; set; }
        public DateTime StartDate { get; set; }
    }
}
