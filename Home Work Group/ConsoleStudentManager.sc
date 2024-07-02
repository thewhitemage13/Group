namespace Home_Work_Group
{
    internal class ConsoleStudentManager : IStudentManager<Student>
    {

        public int AverageGrade(Student student)
        {
            for (int i = 0; i < student.GetExamGrades().Count; i++)
            {
                int r = student.GetExamGrades()[i] / student.GetExamGrades().Capacity;
                student.PlusAverageGrade(r);
            }
            return student.GetAverageGrade();
        }

        public void AddHomeworkGrades(Student student, int grade)
        {
            student.GetHomeworkGrades().Add(grade);
        }

        public void AddExamGrades(Student student, int grade)
        {
            student.GetExamGrades().Add(grade);
        }

        public void AddTermPaperGrades(Student student, int grade)
        {
            student.GetTermPaperGrades().Add(grade);
        }

        //public int CalculateAverageGrade(Student student)
        //{
        //    if (student.GetExamGrades().Count == 0)
        //        return 0;

        //    int total = student.GetExamGrades().Sum();
        //    return total / student.GetExamGrades().Count;
        //}
    }
}
