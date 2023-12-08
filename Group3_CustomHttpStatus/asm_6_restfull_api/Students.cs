using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace asm_6_restfull_api
{
    [BindProperties]
    public class Students
    {
        public Students() { }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        //[StringLength(20)]
        public required string Name { get; set; }

        [Required]
        //[StringLength(20)]
        public required string Grade { get; set; }
    }
}
