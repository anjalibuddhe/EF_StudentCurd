using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_StudentCurd.Models
{
        [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Course { get; set; }
        [Required]
        public string? Duration { get; set; }
        
        public int IsActive { get; set; }
    }
}
