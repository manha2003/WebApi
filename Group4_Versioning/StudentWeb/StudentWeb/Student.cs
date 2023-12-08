namespace StudentWeb
{
    public class Student
    {
        public Student(int id, String name, String gradeId)
        {
            Id = id;
            Name = name;
            GradeId = gradeId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public String GradeId { get; set; }
    }
}
