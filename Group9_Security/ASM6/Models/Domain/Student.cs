namespace ASM6.Models.Domain
{
    public class Student
    {

        public Student(int id, string name, string gradeId)
        {
            Id = id;
            Name = name;
            GradeId = gradeId;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string GradeId { get; set; }

    }
}
