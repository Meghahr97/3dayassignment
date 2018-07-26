using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn2
{
    class Program
    {
        static void Main(string[] args)
        {
            shape s = new shape();
            s.area(10);
            s.area(2, 3);
            s.area(3.175);
            s.area(3, 5.2);
            s.showdata();
        }
    }
}
