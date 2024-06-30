namespace Home_Work_Group
{
    enum Spaciality { SoftwareDeveloper, Designer }

    internal class Group : ICloneable
    {
        private string groupName;
        private int countOfStudent;
        private Spaciality spaciality;
        private int course;
        private List<Student> students = new List<Student>();

        public int GetCountOfStudents()
        {
            return countOfStudent;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudent()
        {
            return students;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }

        public int GetCourse()
        {
            return course;
        }

        public void SetSpaciality(Spaciality spaciality)
        {
            this.spaciality = spaciality;
        }

        public Spaciality GetSpaciality()
        {
            return spaciality;
        }

        public void SetGroupName(string groupName)
        {
            this.groupName = groupName;
        }

        public string GetGroupName()
        {
            return groupName;
        }

        public Group(string groupName, Spaciality spaciality, int course)
        {
            SetGroupName(groupName);
            SetSpaciality(spaciality);
            SetCourse(course);
        }

        public Group(Group group)
        {
            this.groupName = group.groupName;
            this.spaciality = group.spaciality;
            this.course = group.course;
            this.students = new List<Student>();
            foreach (Student student in group.students)
            {
                this.students.Add((Student)student.Clone());
            }
        }

        public object Clone()
        {
            var clonedGroup = new Group(this.groupName, this.spaciality, this.course);
            foreach (Student student in this.students)
            {
                clonedGroup.AddStudent((Student)student.Clone());
            }
            return clonedGroup;
        }
    }
}
