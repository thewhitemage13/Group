using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    internal class ConsoleStudentPrinter : IPrinter<Student>
    {
        public void Print(Student student) 
        {
            Console.WriteLine("Student: \n");
            Console.WriteLine("Surname: " + student.GetName());
            Console.WriteLine("Name: " + student.GetName());
            Console.WriteLine("Lastname: " + student.GetLastname());
            Console.WriteLine("Birthday: " + student.GetBirthday());
            Console.WriteLine("Adress: " + student.GetPhonenumber());
            Console.WriteLine("\nGrades: ");

            Console.Write("Home Work: ");
            foreach (var grade in student.GetHomeworkGrades())
            {
                Console.Write(grade + ", ");
            }
            Console.WriteLine();
            Console.Write("Exams: ");
            foreach (var grade in student.GetExamGrades())
            {
                Console.Write(grade + ", ");
            }
            Console.WriteLine();
            Console.Write("Term Papers: ");
            foreach (var grade in student.GetTermPaperGrades())
            {
                Console.Write(grade + ", ");
            }
            Console.WriteLine();
        }
    }
}
