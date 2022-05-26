using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSAAFINALASSIGNMENT.Models
{
    public  class Patient:Human
    {
        public virtual int id { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual Doctors Doctor { get; set; }

        



        

    }
}
