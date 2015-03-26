using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class IDGenerator
    {
        private int zähler = 0;

        public int GeneriereID()
        {
            zähler++;
            return zähler;
        }
    }
}
