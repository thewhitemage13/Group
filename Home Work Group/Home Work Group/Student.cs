namespace Home_Work_Group
{
    internal class Student : Person, ICloneable
    {
        List<int> homeworkGrades = new List<int>();
        List<int> examGrades = new List<int>();
        List<int> termPaperGrades = new List<int>();

        public void AddHomeworkGrades(int grade)
        {
            homeworkGrades.Add(grade);
        }

        public List<int> GetHomeworkGrades()
        {
            return homeworkGrades;
        }


        public void AddExamGrades(int grade)
        {
            examGrades.Add(grade);
        }

        public List<int> GetExamGrades()
        {
            return examGrades;
        }

        public List<int> GetTermPaperGrades()
        {
            return termPaperGrades;
        }

        public void AddTermPaperGrades(int grade)
        {
            termPaperGrades.Add(grade);
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
            // Копируем все поля
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
