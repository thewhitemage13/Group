namespace Home_Work_Group
{
    internal class Student : Person, ICloneable
    {
        List<int> homeworkGrades = new List<int>();
        List<int> examGrades = new List<int>();
        List<int> termPaperGrades = new List<int>();
        int average_grade;

        public int GetAverageGrade()
        {
            return average_grade;
        }

        public void PlusAverageGrade(int number)
        {
            this.average_grade += number;
        }

        public List<int> GetHomeworkGrades()
        {
            return homeworkGrades;
        }

        public List<int> GetExamGrades()
        {
            return examGrades;
        }

        public List<int> GetTermPaperGrades()
        {
            return termPaperGrades;
        }

        public Student(string surname, string name, string lastname, DateTime birthday, string adress, int phonenumber) : base(surname, name, lastname, birthday, adress, phonenumber)
        {
        }

        public Student(int phonenumber) : base("Lolo", "Mukhammed", "Kamel", DateTime.Now, "Vilkovskaya 38", phonenumber)
        {
        }

        public Student(DateTime birthday, string adress, int phonenumber) : base("Lolo", "Mukhammed", "Kamel", birthday, adress, phonenumber)
        {
        }

        public object Clone()
        {
            var clonedStudent = new Student(
                GetSurname(), GetName(), GetLastname(), GetBirthday(), GetAdress(), GetPhonenumber())
            {
                homeworkGrades = new List<int>(homeworkGrades),
                examGrades = new List<int>(examGrades),
                termPaperGrades = new List<int>(termPaperGrades)
            };
            return clonedStudent;
        }
    }
}
