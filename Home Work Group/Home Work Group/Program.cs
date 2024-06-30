namespace Home_Work_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(0687680685);
            ConsoleStudentPrinter c = new ConsoleStudentPrinter();
            ConsoleGroupPrinter consoleGroupPrinter = new ConsoleGroupPrinter();
            student.AddHomeworkGrades(12);
            student.AddHomeworkGrades(9);
            student.AddExamGrades(2);
            student.AddExamGrades(6);
            student.AddTermPaperGrades(4);
            //c.Print(student);
            Group group = new Group("P260", Spaciality.SoftwareDeveloper, 2);
            group.AddStudent(student);
            //consoleGroupPrinter.Print(group);
            //Group p23 = group;
            Group group2 = new Group(group);
            consoleGroupPrinter.Print(group2);
        }
    }
}
