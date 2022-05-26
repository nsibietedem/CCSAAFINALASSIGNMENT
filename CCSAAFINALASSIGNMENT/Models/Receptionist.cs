using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSAAFINALASSIGNMENT.Models
{
    public class Receptionist:Human
    {
        public virtual Hospital Hospital { get; set; }
    }
}
