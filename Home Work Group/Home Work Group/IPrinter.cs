using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    internal interface IPrinter <T>
    {
        public void Print(T obj);
    }
}
