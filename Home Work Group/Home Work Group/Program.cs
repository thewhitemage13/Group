namespace Home_Work_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student
            Student student1 = new Student("Lolo", "Mukhammed", "Kamel",  DateTime.Now, "", 102);
            Student student2 = new Student("X", "XX", "XXXX", DateTime.Now, "", 103);
            // student manager
            ConsoleStudentManager consoleStudentManager = new ConsoleStudentManager();
            // student printer
            ConsoleStudentPrinter consoleStudentPrinter = new ConsoleStudentPrinter();
            // Group
            Group p23 = new Group("P23", Spaciality.SoftwareDeveloper, 2);
            Group p26 = new Group("P26", Spaciality.SoftwareDeveloper, 2);
            // group manager
            ConsoleGroupManager consoleGroupManager = new ConsoleGroupManager();
            // Group Printer
            ConsoleGroupPrinter consoleGroupPrinter = new ConsoleGroupPrinter();
            // Test
            // Student 1
            consoleStudentManager.AddHomeworkGrades(student1, 12);
            consoleStudentManager.AddHomeworkGrades(student1, 9);
            consoleStudentManager.AddHomeworkGrades(student1, 10);
            consoleStudentManager.AddExamGrades(student1, 2);
            consoleStudentManager.AddExamGrades(student1, 3);
            consoleStudentManager.AddExamGrades(student1, 1);
            consoleStudentManager.AddTermPaperGrades(student1, 2);
            // Student 2
            consoleStudentManager.AddHomeworkGrades(student1, 1);
            consoleStudentManager.AddHomeworkGrades(student1, 1);
            consoleStudentManager.AddHomeworkGrades(student1, 1);
            consoleStudentManager.AddExamGrades(student1, 1);
            consoleStudentManager.AddExamGrades(student1, 1);
            consoleStudentManager.AddExamGrades(student1, 1);
            consoleStudentManager.AddTermPaperGrades(student1, 1);
            // 
            consoleGroupManager.AddStudent(p23, student1);
            consoleGroupManager.AddStudent(p23, student2);
            //
            //consoleGroupPrinter.Print(p23);
            //consoleGroupManager.Expel(p23);
            consoleGroupManager.TransferStudent(p23, p26, student1);
            consoleGroupPrinter.Print(p26);
            consoleGroupPrinter.Print(p23);

        }
    }
}
