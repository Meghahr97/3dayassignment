using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn2
{
    [AttributeUsage(AttributeTargets.Method)]
    class CustomerAttribute:Attribute
    {
       
        public string Methodname { get; set; }
        public string ReturnType { get; set; }
        public string Parameter { get; set; }
        public string Message { get; set; }
    }
}
