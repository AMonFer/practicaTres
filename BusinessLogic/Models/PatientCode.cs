using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPB.BusinessLogic.Models
{
    public class PatientCode
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI { get; set; }
        public PatientCode()
        {

        }
        public PatientCode(string name, string lastName, int cI)
        {
            Name = name;
            LastName = lastName;
            CI = cI;
        }
    }
}
