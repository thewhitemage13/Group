using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    internal class ConsoleGroupPrinter : IPrinter<Group>
    {
        public void Print(Group group)
        {
            Console.WriteLine("Group:");
            Console.WriteLine("Group name: " + group.GetGroupName());
            Console.WriteLine("Spaciality: " + group.GetSpaciality());
            Console.WriteLine("Count of student: " + group.GetCountOfStudents());
            Console.WriteLine("Students: ");
            foreach(var d in group.GetStudent())
            {
                Console.WriteLine(d.ToString());
            }

        }
    }
}
