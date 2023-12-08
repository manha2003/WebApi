using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StudentManagement.Models
{
    
    public class Student
    {
       
        [Key]
        public int StudentID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        
        public string StudentName { get; set; } = "";
       
        public string StudentEmail { get; set;}
        
        public int StudentAge {  get; set;}
        
        public string StudentPhone { get; set;}
        
    }
}
