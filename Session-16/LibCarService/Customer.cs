using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Customer : Person
    {
        public string Phone { get; set; }
        public string TIN { get; set; }

        public Transaction Transaction { get; set; }

        public Customer() : base()
        {

        }
    }
}
