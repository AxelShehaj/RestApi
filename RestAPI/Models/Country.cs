using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class Country
    {
        public Name name { get; set; }
        public string status { get; set; }
    }
    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
    }
}
