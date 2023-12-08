using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPISample
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

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "GradeId is required")]
        public string GradeId { get; set; }
    }
}
