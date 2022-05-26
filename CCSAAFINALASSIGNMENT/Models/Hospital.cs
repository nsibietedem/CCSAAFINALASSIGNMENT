using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSAAFINALASSIGNMENT.Models
{
    public class Hospital
    {
        public virtual  int Id { get; set; }
        public virtual  string HospitalName { get; set; }
        public virtual  string  Address { get; set; }
        public virtual  List<Doctors> Doctors { get; set; }               
        public virtual  List<Nurses> Nurses { get; set; }
        public virtual  List<Pharmacist> Pharmacist { get; set; }
        public virtual  Accountant Accountants { get; set; }               
        public virtual  Receptionist Receptionist { get; set; }


    }
}
