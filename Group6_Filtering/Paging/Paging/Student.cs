using System.ComponentModel.DataAnnotations;

namespace Paging
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public string GradeId { get; set; }
	}
}