using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    internal interface IGroupManager<T1, T2>
    {
        public void Expel(T1 obj1);

        public void FlunkedOut(T1 obj1);

        public void AddStudent(T1 obj1, T2 obj2);

        public void RemoveStudent(T1 obj1, T2 obj2);

        public void TransferStudent(T1 obj1, T1 obj2, T2 Obj3);
    }
}
