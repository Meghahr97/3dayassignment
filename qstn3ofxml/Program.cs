using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn3ofxml
{
    class Program
    {
        static void Main(string[] args)
        {
            readxml xml = new readxml();
            //xml.writeXml();
            xml.readml(); 
        }
    }
}
